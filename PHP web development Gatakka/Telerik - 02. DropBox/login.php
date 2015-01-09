<?php session_start(); ?>
<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta charset="utf-8" />
		<title>Вход</title>
		<style>
			input {
				margin: 10px;
				height: 40px;
				font-size: 24px;
			}
		</style>
	</head>
	<body>

		<form method="post">
			<input type="text" name="username" placeholder="username" />
			<br />
			<input type="password" name="pass" placeholder="password" />
			<br />
			<input type="submit" name="submit" value="Вход" />
			<br />
		</form>

		<?php 
		
    	mb_internal_encoding('UTF-8');
    	if (isset($_POST['submit'])) {
				//normalization on input data
			$name = trim($_POST['username']);
			str_replace("|", "", $name);
			
			$password = trim($_POST['pass']);
			str_replace("|", "", $password);
			$error = false;
				// check name in DB
				
			$register = file("register.txt");
			
			foreach ($register as $key => $value) {
				$parts = explode("|", $value);
				//trim all parts
				foreach ($parts as $key => $value) {
					$parts[$key] = trim($value);
				}
				//check for valid user
				if ($parts[0] == $name && $parts[1] == $password) {
					$_SESSION['name'] = $name;
					header('Location: details.php');
					exit;
				}
				else {
					echo "<p>Грешно име или парола. Опитайте отново! </p>";
				}
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