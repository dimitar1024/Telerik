<?php
ob_start();
$title = 'Регистрация';
include 'includes/header.php';
include 'includes/functions.php';
?>
<nav>
	<ul>
		<li>
			<a href="login.php">Вход</a>
		</li>
		<li>
			<a href="index.php">Книги</a>
		</li>
		<li>
			<a href="book.php">Нова Книга</a>
		</li>
		<li>
			<a href="author.php">Нов Автор</a>
		</li>
	</ul>
</nav>
<form  id="register" class="insert" method="post">
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
		if (isset($_POST['submit'])) {
				
		$name = trim($_POST['username']);
		$name_esc = mysqli_real_escape_string($db,$name);
		$password = htmlspecialchars(trim($_POST['pass']));
		$pass_esc = mysqli_real_escape_string($db, $password);
		$email = trim($_POST['email']);
		$email_esc = mysqli_real_escape_string($db, $email);
		$error = false;
		

		$sql = "SELECT * FROM users WHERE username = '$name_esc' ";
		$q = mysqli_query($db, $sql);
		$row_count = mysqli_num_rows($q);
			if ($row_count > 0) {
				echo "<p>Вече съществува потребител с това потребителско име. Опитайте отново! </p>";
				$error = true;
			}
			
			if (mb_strlen($name_esc) < 5) {
					echo "<p>Името е по-малко от 5 символа. Опитайте отново! </p>";
					$error = true;
			}
			
			if (mb_strlen($password) < 5) {
					echo "<p>Паролата е прекалено къса от 5 символа. Моля опитайте отново!</p>";
					$error = true;
			}
			
			if (mb_strlen($password) > 32) {
					echo "<p>Паролата е прекалено дълга от 32 символа. Моля опитайте отново!</p>";
					$error = true;
			}

			if (!$error) {
				$timeNow = date("Y-m-d H:i:s");
				$sql = "INSERT INTO users(username,password,email,date) VALUES ('" . mysqli_real_escape_string($db,$name) . "','" . mysqli_real_escape_string($db,$password) . "','" . mysqli_real_escape_string($db,$email) . "','" .$timeNow . "')";
				echo $sql;
				$q = mysqli_query($db, $sql);
				if (mysqli_error($db)) {
					echo "<p>Error</p>";	
				}
				echo "<p>Регистрирахте се успешно успешно!</p>";
				header('Location: login.php');
				exit;
			}
		}
	?>

<?php
include 'includes/footer.php';
?>

