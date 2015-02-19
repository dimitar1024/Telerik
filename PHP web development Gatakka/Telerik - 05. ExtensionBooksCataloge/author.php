	<?php
	ob_start();
	$title = 'Въвеждане на автор';
	include 'includes/header.php';
	include 'includes/functions.php';
	?>
	<nav>
		<ul>
			<li>
				<a href="index.php">Книги</a>
			</li>
		
		</ul>
	</nav>

<form method="POST" action="author.php" class="insert">
	<label for="author">Автор</label>
	<input id="author" name="author" type="text" placeholder="Име на автора..."/>
	<input type="submit" value="Добави" name="submit" />
</form>
	<?php
		$error = false;
		if (isset($_POST['submit'])) {
			$author_name = htmlspecialchars(trim($_POST['author']));
			$author_esc = mysqli_real_escape_string($db, $author_name);
		
			if (mb_strlen($author_name) < 3) {
				$error = true;
				echo "<p class='error'>Невалидно име. Опитайте отново!</p>";
			}
		
			$sql = "SELECT * FROM authors WHERE author_name='" . $author_esc . "'";
			$q = mysqli_query($db, $sql);
		
			if (mysqli_num_rows($q) > 0) {
				echo "<p class='error'>Авторът съществува. Опитайте отново!</p>";
				$error = true;
			}
		
			if (!$error) {
				$sql = "INSERT INTO `authors`(`author_name`) VALUES ('" . $author_esc . "')";
				mysqli_query($db, $sql);
				if (mysqli_error($db)) {
					echo "<p class='error'>Грешка. Опитайте отново!</p>";
				} else {
					echo "<p>Въведохте автор успешно!</p>";
				}
			}
		}
		
		$author_list = getAuthors($db);
	?>
	
	
<table>
	<tr>
		<th>Автори</th>
	</tr>
	<?php
		foreach ($author_list as $value) {
			echo "<tr><td>".$value['author_name']."</td></tr>";
		}
	?>
</table>

	<?php
	include 'includes/footer.php';
	?>

