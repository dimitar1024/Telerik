<?php session_start(); ?>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title></title>
		<meta charset="utf-8" />
		
	</head>
	<body>
		<a href="details.php" >Назад</a>
		<a href="destroy.php" >Изход от системата</a>
		<table border="1">
			<tr>
				<th>№</th>
				<th>Файл</th>
				<th>Тип файл</th>
				<th>Размер</th>
				
			</tr>

			<?php
				$name = $_SESSION['name'];
				$dir = 'users' . DIRECTORY_SEPARATOR . "$name";
				$files = scandir($dir);
				
				$count = 1;
				for ($i = 2; $i < count($files); $i++) {
					$fname = $files[$i];
					
					$path = "users/$name/$fname";
					$size = filesize_formatted($path);
					$ext = pathinfo($path, PATHINFO_EXTENSION);
					
					//print info
					echo "<tr>";
					echo "<td>$count</td>";
					echo "<td><a href=\"users/$name/$fname\">$fname</a></td>";
					echo "<td>$ext</td>";
					echo "<td>$size</td>";
					echo "</tr>";
					$count++;
				}
				
				
				function filesize_formatted($path)
				{
				    $size = filesize($path);
				    $units = array( 'B', 'KB', 'MB', 'GB', 'TB', 'PB', 'EB', 'ZB', 'YB');
				    $power = $size > 0 ? floor(log($size, 1024)) : 0;
				    return number_format($size / pow(1024, $power), 2, '.', ',') . ' ' . $units[$power];
				}
    		?>
		</table>
	</body>
</html>