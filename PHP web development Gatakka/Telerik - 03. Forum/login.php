<?php session_start(); ?>
<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta charset="utf-8" />
		<title>Вход</title>
		<link href="style.css" rel="stylesheet" />
	</head>
	<body>
		<header>
			<h1>My IT Forum</h1>
		</header>
		<ul>
			<li >
				<a href="register.php">Регистрация</a>
			</li>
			<li class="select">
				<a href="login.php">Вход</a>
			</li>
		</ul>
		<form  class="login" method="post">
			<br/>
			<label for="name">Потребителско име</label><br/>
			<input id="name" type="text" name="username" placeholder="username" />
			<br />
			<label for="pass">Парола</label><br/>
			<input id="pass"type="password" name="pass" placeholder="password" />
			<br />
			<input type="submit" name="submit" value="Вход" />
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
		$error = false;
		// check name in DB

		$sql = "SELECT * FROM users";
		$q = mysqli_query($connection, $sql);
		while ($row = $q -> fetch_assoc()) {
			if ($row['username'] == $name && $row['password'] == $password) {
				$_SESSION['name'] = $name;
				header('Location: messages.php');
				exit ;
			} else {
				$error = TRUE;
			}
		}
		if ($error) {
			echo "<p>Грешно име или парола. Опитайте отново! </p>";
		}

		if (mb_strlen($name) < 5) {
			echo "<p>Името е по-малко от 5 символа. Опитайте отново! </p>";
			$error = TRUE;
		}

		if (mb_strlen($password) < 5 && mb_strlen($password) > 32) {
			echo "<p>Грешна парола. Моля опитайте отново!</p>";
			$error = TRUE;
		}
	}
		?>
	</body>
</html>