<?php
	ob_start();
	$title = 'Начало';
	include 'includes/header.php';
	include 'includes/functions.php';
	?>
	<nav>
		<ul>
			<?php 
				if (!isset($_SESSION['isLogged'])) {
					echo"<li><a href=\"login.php\">Вход</a></li>";
				}
			?>
			
			<li>
				<a href="index.php">Книги</a>
			</li>
			<li>
				<a href="book.php">Нова Книга</a>
			</li>
			<li>
				<a href="author.php">Нов Автор</a>
			</li>
			
			<?php 
				if (isset($_SESSION['isLogged'])) {
					echo"<li><a href=\"destroy.php\">Изход</a></li>";
				}
			?>
			
		</ul>
	</nav>
		
		<?php
			
			if (isset($_GET['author_id'])) {
				$autor_id = (int) $_GET['author_id'];
				$sql = "SELECT * FROM books_authors as ba INNER JOIN books as b ON ba.book_id=b.book_id 
				INNER JOIN books_authors as bba ON bba.book_id=ba.book_id 
				INNER JOIN `authors` as a ON bba.author_id=a.author_id WHERE ba.author_id=".$autor_id;
				$q = mysqli_query($db, $sql);
			}
			else
			{
				
				$sql = "SELECT * FROM books as b INNER JOIN books_authors as ba ON b.book_id=ba.book_id 
				INNER JOIN authors as a ON a.author_id=ba.author_id ";
				$q = mysqli_query($db, $sql);
				
				$comments_sql = "SELECT * FROM `comments`";
				$comments = mysqli_query($db, $comments_sql);
				
			}
			if (mysqli_error($db)) {
				echo "Error";
				exit;
				}
			
			$commentCount = array();
			while ($row = $comments -> fetch_assoc()) {
				if (!isset($commentCount[$row['book_id']])) {
					$commentCount[$row['book_id']] = 1; 
				}
				else {
					$commentCount[$row['book_id']]++;
				}
				
			}
			
			$result = array();
			while ($row = $q -> fetch_assoc()) {
				$result[$row['book_id']]['book_title']=$row['book_title'];
				$result[$row['book_id']]['authors'][$row['author_id']]=$row['author_name'];
				
			}
			
			
			foreach ($result as $key => $value) {
					
				foreach ($commentCount as $k => $v) {
						
						
					if ($key == $k) {
						$result[$key]['comments'] = $v;
					}
					
				}
				
			}
			
			
		?>
		<table>
			<tr>
				<th>Кинга</th>
				<th>Автори</th>
				<th class="td-comment">Коментари</th>
			</tr>
			
			<?php 
				foreach ($result as $key=>$row) {
					
					echo "<tr><td><a title=\"Виж коментарите към тази книга\"href=\"comments.php?book_id=".$key."\"/>".$row['book_title']."</a></td><td>";
					$ar = array();
					foreach ($row['authors'] as $k=>$aut) {
						$ar[]= "<a title=\"Виж всички книги на този автор\" href=\"index.php?author_id=".$k."\"/>".$aut."</a>";
					}
					$res = implode(' , ', $ar);
					echo "$res </td>";
					
					$coments = 0;
					if (isset($row['comments'])) {
						$coments = $row['comments'];
					}
					echo "<td class=\"td-comment\"><a title=\"Виж коментарите\"href=\"comments.php?book_id=".$key."\"/>".$coments."</a></td></tr>";
				}
			?>
			
		</table>

<?php
	include 'includes/footer.php';
	?>


