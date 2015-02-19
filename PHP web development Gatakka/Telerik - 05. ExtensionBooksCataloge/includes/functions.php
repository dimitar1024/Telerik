<?php 
	session_start(); 
	date_default_timezone_set("Europe/Sofia");

    mb_internal_encoding('UTF-8');
	$db = mysqli_connect("localhost", "dimitar1024", "matematika", "bookcataloge");
	if (!$db) {
		echo "<p class='error'>no connection with database</p>";
		exit ;
	}
	mysqli_set_charset($db, 'utf8');
	
	function getAuthors($db)
	{
		$result = array();
		$sql = "SELECT * FROM authors";
		$q= mysqli_query($db, $sql);
		if (mysqli_error($db)) {
			return false;
		}
		while ($row = $q -> fetch_assoc()) {
		$result[] = $row;
		}
		
		return $result;
	}
	
	function isAuthorsIdExists($db,$id)
	{
		$id = (int)$id;
		$q = mysqli_query($db, "SELECT * FROM authors WHERE author_id =". $id);
		if (mysqli_error($db)>0) {
			return false;
		}
		if (mysqli_num_rows($q)==1) {
			return true;
		}
		return false;
	}
?>