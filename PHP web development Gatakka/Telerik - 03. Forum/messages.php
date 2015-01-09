<?php session_start(); ?>
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
			
			<li>
				<a href="upload.php"> Ново съобщение</a>
			</li>
			<li>
				<a href="destroy.php">Изход от системата</a>
			</li>
		</ul>
		<article>
			<header>
				<h2> Съобщения </h2>
			</header>
		</article>
		<article>
			<form method="post">
			Сортирай по
			<select name="property">
		        <option value="date" selected="selected">Дата</option>
		        <option value="user">Потребител</option>
		        <option value="title">Заглавие</option>
		        <option value="message">Съобщения</option>
		        <option value="group">Група</option>
		    </select>
		    Ред
		    <select name="order" id="order">
                    <option value="ascending">Възходящ</option>
                    <option value="descending">Низходящ</option>
                </select>
		    <input type="submit" value="Филтрирай"/>
		    </form>
		</article>
		<?php
		$connection = mysqli_connect("localhost", "dimitar1024", "matematika", "telerik-03-forum");
		$sql = "SELECT * FROM messages";
		$q = mysqli_query($connection, $sql);
		$option = array("", "C#", "Java", "HTML", "CSS", "JavaScript", "PHP", "MySQL", "Regex");
		$query = array();
		while ($row = $q -> fetch_assoc()) {
			$currentRow = new stdClass();
			$currentRow-> user = trim($row['user']);
			$currentRow-> title = trim($row['title']);
			$currentRow-> message = trim($row['message']);
			$currentRow-> group = trim($row['group']);
			$currentRow-> date = strtotime($row['date']);
			$query[] = $currentRow;
		}
		
	
		
		if ($_POST) {
			$property = $_POST['property'];
		$order = $_POST['order'];
		usort($query, function($s1, $s2) use ($order, $property) {
			if ($s1 ->$property == $s2 ->$property) {
				return strcmp($s1 -> title, $s2 ->title);
			}

			return ($order == "ascending" ^ $s1 -> $property < $s2 -> $property) ? 1 : -1;
		});
		}
		
		foreach ($query as $row) {
			
		
			//print_r($row);
			echo '<article><img class="bulet" src="img/bulet.png" alt=\"bulet\" />';
			echo '<h3>'.$row->title.'</h3>';
			echo '<p>' . $row->message . '</p>';
			
			echo '<p class="user">user:<span>' . $row->user . '</span>';
			echo 'theme:<span>' . $option[$row->group] . '</span>';
			$magDate = date("Y-m-d H:i:s",$row->date);
			echo 'date:<span>' . $magDate . '</span></p></article>';

		}
		?>
	</body>
</html>