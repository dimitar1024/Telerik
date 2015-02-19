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
					
			<?php 
				if (isset($_SESSION['isLogged'])) {
					echo"<li><a href=\"destroy.php\">Изход</a></li>";
				}
			?>
			
		</ul>
	</nav>
	<main>
		<header class="com-header">
			<h2>Коментари</h2>
		</header>
	<?php 
		$id = mysqli_real_escape_string($db, $_GET['book_id']);
		$sql ="SELECT * FROM comments as c INNER JOIN users as u ON c.user_id=u.user_id LEFT JOIN books as b ON c.book_id=b.book_id WHERE c.book_id=". $id." ORDER BY c.comment_date DESC";
		$q = mysqli_query($db, $sql);
		if (mysqli_error($db)) {
			echo "<p>Error</p>";
			echo mysqli_error($db);	
		}
		
		while ($row = $q -> fetch_assoc()) {
			echo"<article>";
				echo"<h3>".$row['book_title']."</h3>";
				echo"<p>".$row['msg']."</p>";
				echo"<p>#<span>".$row['comment_id']."</span>Потребител:<span><a href=\"allcomments.php?user_id=".$row['user_id']."\">".$row['username']."</a></span>Дата:<span>".$row['comment_date']."</span></p>";
			echo"</article>";
		}
	?>	
	<?php
		$sql ="SELECT * FROM books";
		$q = mysqli_query($db, $sql);
		if (mysqli_error($db)) {
			echo "<p>Error</p>";
			echo mysqli_error($db);	
		}
		echo "<header class=\"com-header\"><h2>Вижте коментарите и на другите книги</h2></header>";
		echo "<ul>";
		
		while ($row = $q -> fetch_assoc()) {
			echo "<li><a href=\"comments.php?book_id=".$row['book_id']."\"/>".$row['book_title']."</a></li>";
		}
		echo "</ul>";
		
	?>
	<?php 
		if (isset($_SESSION['isLogged'])) {
			echo "<form  class=\"insert\"id=\"comment\" method=\"post\">";
			echo "<label for=\"msg\">Коментар</label><br/>";
			echo "<textarea id=\"msg\" name=\"msg\"></textarea><br>";
			echo "<input type=\"submit\" name=\"submit\" value=\"Изпрати\" /><br /></form>";
		}
		else{
			echo "<div id=\"err\"><p>Нямате право да коментирате. Моля влезте с <a class=\"link\" href=\"login.php\">вашата регистрация</a> или се <a class=\"link\" href=\"register.php\">регистрирайте</a><p></div>";
		}
	?>
	
	</main>
	<?php
		if(isset($_POST['submit'])){
		$user_id_esc = mysqli_real_escape_string($db,$_SESSION['user_id']);
		$book_id_esc = mysqli_real_escape_string($db,$_GET['book_id']);
		$msg = mysqli_real_escape_string($db, $_POST['msg']);
		$timeNow = date("Y-m-d H:i:s");
		$error = false;
		
		if(mb_strlen($msg) < 50){
			echo "<p>Коментара е по-къс от 50 символа. Моля опитайте отново!</p>";
			$error = TRUE;	
		}
		
		if(mb_strlen($msg) > 500){
			echo "<p>Коментара е по-дълъг от 500 символа. Моля опитайте отново!</p>";
			$error = TRUE;	
		}
		
		if (!$error) {
			$sql ="INSERT INTO `comments`(`user_id`, `book_id`, `msg`, `comment_date`) 
			VALUES ($user_id_esc,$book_id_esc,'$msg','$timeNow' )";
			$q = mysqli_query($db, $sql);
			if (mysqli_error($db)) {
				echo "<p>Error</p>";
				echo mysqli_error($db);	
			}
			echo "<p>Коментарът е изпратен успешно!</p>";
			header("refresh: 0;");
		
		}
		}
	?>	
		

<?php
	include 'includes/footer.php';
	?>


