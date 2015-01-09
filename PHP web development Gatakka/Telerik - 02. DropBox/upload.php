<?php session_start(); ?>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title></title>
		<meta charset="utf-8" />

	</head>
	<body>
		<a href="details.php" >Назад</a>
		<a href="destroy.php" >Изход от системата</a>
		<form method="post" enctype="multipart/form-data">
			Файл:
			<input type="file" name="file" />
			<input type="submit" value="КАЧИ">
		</form>

		<?php
		if (isset($_FILES['file'])) {
			$userFolder = $_SESSION['name'];
			$uploads_dir = 'users' . DIRECTORY_SEPARATOR . "$userFolder";

			$tmp_name = $_FILES["file"]["tmp_name"];
			$name = $_FILES["file"]["name"];
			move_uploaded_file($tmp_name, "$uploads_dir/$name");

		}
		?>
	</body>
</html>