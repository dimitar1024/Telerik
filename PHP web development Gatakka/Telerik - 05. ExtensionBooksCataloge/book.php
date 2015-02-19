<?php
	ob_start();
	$title = 'Въвеждане на книги';
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
		
		<form method="GET" action="book.php" class="insert">
		<label for="book">Име на книгата</label>
		<input id="book" name="book" type="text" placeholder="Име на книгата..."/>
		<select multiple="multiple" name="authors[]">
		<?php 
			$author_list =getAuthors($db);
			
			foreach ($author_list as $value) {
				echo"<option value='".$value['author_id']."'>". trim($value['author_name'])."</option>";
			}
		?>
		</select> 
		<input type="submit" value="Добави" name="submit" /> 
		</form>
	<?php
		if (isset($_GET['submit'])) {
			$book_name = htmlspecialchars(trim($_GET['book']));
			$authors = $_GET['authors'];
			$book_esc = mysqli_real_escape_string($db, $book_name);
			$error = false;
			
			if (mb_strlen($book_name) < 3) {
				echo "<p class='error'>Невалидно име. Опитайте отново!</p>";
				$error=true;
			}
			if (count($authors)==0) {
				echo "<p class='error'>Не сте избрали автор(и). Опитайте отново!</p>";
				$error=true;
			}
			
			foreach ($authors as $a) {
				if (!isAuthorsIdExists($db,$a)) {
					$error = true;
					echo "<p class='error'>Невалиден автор. Опитайте отново!</p>";
				}	
			}
			
			
			$sql = "SELECT * FROM books WHERE book_title='" . $book_esc . "'";
			$q = mysqli_query($db, $sql);
		
			if (mysqli_num_rows($q) > 0) {
				echo "<p class='error'>Книгата съществува. Опитайте отново!</p>";
				$error = true;
			}
			
			if (!$error) {
				$sql = "INSERT INTO `books`(`book_title`) VALUES ('" . $book_esc . "')";
				$q = mysqli_query($db, $sql);
				
				if (mysqli_error($db)) {
					echo "Error";
					exit;
				}
				$id = mysqli_insert_id($db);
				
				foreach ($authors as $aID) {
					$sql = "INSERT INTO `books_authors`(`book_id`, `author_id`) VALUES (".$id.",".$aID.")";
					$q = mysqli_query($db, $sql);
					if (mysqli_error($db)) {
					echo "Error";
					exit;
					}
				}
				echo "<p>Въведохте книга успешно!</p>";
			}
		}
		
	?>
	<?php
	include 'includes/footer.php';
	?>


