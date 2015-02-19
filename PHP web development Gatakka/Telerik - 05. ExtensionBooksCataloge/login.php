<?php
	ob_start();
	$title = 'Вход';
	include 'includes/header.php';
	include 'includes/functions.php';
	?>
	<nav>
		<ul>
			<li>
				<a href="login.php">Вход</a>
			</li>
			<li>
				<a href="register.php">Регистрация</a>
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
	<form method="post" class="insert">
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

	
	if (isset($_POST['submit'])) {
		
		$name = htmlspecialchars(trim($_POST['username']));
		$password = htmlspecialchars(trim($_POST['pass']));
		$error = false;
		

		$sql = "SELECT * FROM users";
		$q = mysqli_query($db, $sql);
		while ($row = $q -> fetch_assoc()) {
			if ($row['username'] == $name && $row['password'] == $password) {
				$_SESSION['user_id'] = $row['user_id'];
				$_SESSION['name'] = $name;
				$_SESSION['isLogged'] = true;
				header('Location: index.php');
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
		
<?php
	include 'includes/footer.php';
	?>


