<?php session_start();
date_default_timezone_set("Europe/Sofia");
mb_internal_encoding('UTF-8');
?>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title></title>
		<meta charset="utf-8" />
		<link href="style.css" rel="stylesheet" />
	</head>
	<body>
		<header>
			<h1>My IT Forum</h1>
		</header>
		<ul>
			<li><a href="messages.php" >Назад</a></li>
			<li><a href="destroy.php" >Изход от системата</a></li>
		</ul>
		<form  id="upload" method="post" enctype="multipart/form-data">
			<br/>
			<label for="name">Заглавие</label>
			<input id="name" type="text" name="title"/>

			<label for="group">Тема</label>
			<select id="group" name="group">
				<option value="1">C#</option>
				<option value="2">Java</option>
				<option value="3">HTML</option>
				<option value="4">CSS</option>
				<option value="5">JavaScript</option>
				<option value="6" selected="selected">PHP</option>
				<option value="7">MySQL</option>
				<option value="8">Regex</option>
			</select>
			<br/>
			<label for="message">Съобщение</label><br/>
			<textarea id="message" name="message"></textarea>
			<br/>
			<input type="submit" name="submit" value="Изпрати" />
		</form>

		<?php
		$connection = mysqli_connect("localhost", "dimitar1024", "matematika", "telerik-03-forum");
		if (!$connection) {
			echo "<p>no connection with database</p>";
			exit ;
		}
		if (isset($_POST['submit'])) {
			$userName = $_SESSION['name'];
			$title = $_POST['title'];
			$message = $_POST['message'];
			$group = $_POST['group'];
			$dateNow = date("Y-m-d H:i:s");
			$error = false;

			if (mb_strlen($title) < 1) {
				echo "<p> Съобщението е без заглавие. Опитайте отново! </p>";
				$error = true;
			}
			if (mb_strlen($title) > 50) {
				echo "<p> Съобщението е с твърде дълго заглавие. Опитайте отново! </p>";
				$error = true;
			}

			echo strlen($message);
			if (mb_strlen($message) < 1) {
				echo "<p> Не сте въвели съобщение. Опитайте отново! </p>";
				$error = true;
			}
			if (mb_strlen($message) > 250) {
				echo "<p> Съобщението е по-дълго от 250 символа. Опитайте отново! </p>";
				$error = true;
			}

			if (!$error) {

				$sql = "INSERT INTO `messages`(user, `title`, `message`, `group`, `date`) VALUES ('". mysqli_real_escape_string($connection, $userName)."','".mysqli_real_escape_string($connection, $title)."','".mysqli_real_escape_string($connection, $message)."','".mysqli_real_escape_string($connection, $group)."','". mysqli_real_escape_string($connection, $dateNow) . "')";
				$q = mysqli_query($connection, $sql);
				echo "<p>Успешно изпратено!</p>";
				header('Location: messages.php');
				exit ;
			}

		}
		?>
	</body>
</html>