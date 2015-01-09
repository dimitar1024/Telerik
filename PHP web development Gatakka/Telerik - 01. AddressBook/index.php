<?php
	$pageTitle = 'Списък';
    include 'includes/header.php';
?>

<div>
        <table>
        	<tr>
        		<th>Име</th>
        		<th>Телефон</th>
        		<th>Група</th>
        	</tr>
        	<?php
        		if (file_exists('data.txt')) {
					$result = file('data.txt');
					foreach ($result as $value) {
						$columns = explode('|', $value);
						
						echo '<tr>
			        		<td>'.$columns[0].'</td>
			        		<td>'.$columns[1].'</td>
			        		<td>'.$groups[trim($columns[2])].'</td>
			        	</tr>';
					}
				}
        	?>
        	
        	
        </table>
        <div class='btn'>
        	<a href="form.php">Добави</a>
        </div>
        
</div>

<?php
	include 'includes/footer.php';
?>


