<?php session_start(); 
date_default_timezone_set("Europe/Sofia");
?>
<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta charset="utf-8" />
		<title>Регистрация</title>
		<link href="style.css" rel="stylesheet" />
	</head>
	<body>
		<header>
			<h1>My IT Forum</h1>
		</header>
		<ul>
			<li class="select">
				<a href="register.php">Регистрация</a>
			</li>
			<li>
				<a href="login.php">Вход</a>
			</li>
		</ul>
		<form  id="register" method="post">
			<br/>
			<label for="name">Потребителско име</label>
			<input id="name" type="text" name="username" placeholder="username" required="required" />
			<br />
			<label for="pass">Парола</label>
			<input id="pass" type="password" name="pass" placeholder="password" required="required"/>
			<br />
			<label for="email">Е-майл</label>
			<input id="email" type="email" name="email" placeholder="email" required="required"/>
			<br />
			<input type="submit" name="submit" value="Регистрация" />
			<br />
		</form>

		<?php
			mb_internal_encoding('UTF-8');
			$connection = mysqli_connect("localhost", "dimitar1024", "matematika", "telerik-03-forum");
			if (!$connection) {
				echo "<p>no connection with database</p>";
				exit ;
			}
			if (isset($_POST['submit'])) {
				//normalization on input data
				$name = htmlspecialchars(trim($_POST['username']));
				$password = htmlspecialchars(trim($_POST['pass']));
				$email = trim($_POST['email']);
				$error = false;
				// check name in DB
		
				$sql = "SELECT * FROM users WHERE username = '.$name.' ";
				$q = mysqli_query($connection, $sql);
				$row_count = mysqli_num_rows($q);
				if ($row_count > 0) {
					echo "<p>Вече съществува потребител с това потребителско име. Опитайте отново! </p>";
					$error = TRUE;
				}
		
				if (mb_strlen($name) < 5) {
					echo "<p>Името е по-малко от 5 символа. Опитайте отново! </p>";
					$error = TRUE;
				}
		
				if (!strpos($email, "@")) {// This is the most stupid way to being validated enamel.
					// The correct way is with Regex, I understand and I can write, but now this project is studying query in SQL
					echo "<p>Невалиден e-mail. Опитайте отново! </p>";
					$error = TRUE;
				}
		
				if (mb_strlen($password) < 5 && mb_strlen($password) > 32) {
					echo "<p>Грешна парола. Моля опитайте отново!</p>";
					$error = TRUE;
				}
		
				if (!$error) {
		
					$timeNow = date("Y-m-d H:i:s");
					$sql = "INSERT INTO users(username,password,email,date) VALUES ('" . mysqli_real_escape_string($connection, $name) . "','" . mysqli_real_escape_string($connection, $password) . "','" . mysqli_real_escape_string($connection, $email) . "','" .$timeNow . "')";
					$q = mysqli_query($connection, $sql);
					echo "<p>Регистрирахте се успешно успешно!</p>";
					header('Location: index.php');
					exit;
		
				}
			}
		?>
	</body>
</html>