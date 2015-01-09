<?php
	$pageTitle = 'Списък';
    include 'includes/header.php';
?>

<div>
	<form method="get">
		
	
	<select name="group" id='group'>
		<option selected="selected" value="0">Всичко</option>
            <?php 
            foreach ($groups as $key => $value) {
                echo '<option ';
                if ((int)$_GET['group']== $key) {
                    echo 'selected="selected"';
                }
                echo 'value="'.$key.'">'.$value.'</option>';
            }
                
            ?>
            
        </select>
        <input type="submit" name="submit" value="Filter"/>
        </form>
        <table>
        	<tr>
        		<th>Дата</th>
        		<th>Име</th>
        		<th>Сума</th>
        		<th>Вид</th>
        	</tr>
        	<?php
        		if (file_exists('data.txt')) {
					$result = file('data.txt');
					$total = 0;
					foreach ($result as $value) {
						
						$columns = explode('|', $value);
						if (((int)$_GET['group']!=(int)$columns[3]) && (int)$_GET['group'] > 0) {
							continue;
						}
						$total += (float)$columns[2];
						echo '<tr>
							<td>'.$columns[0].'</td>
			        		<td>'.$columns[1].'</td>
			        		<td>'.$columns[2].' лв'.'</td>
			        		<td>'.$groups[trim($columns[3])].'</td>
			        	</tr>';
					}
				}
				echo '<tr>
							<td></td>
			        		<td>Общо</td>
			        		<td>'.$total.' лв'.'</td>
			        		<td></td>
			        	</tr>';
        	?>
        	
        	
        </table>
        <div class='btn'>
        	<a href="form.php">Добави</a>
        </div>
        
</div>

<?php
	include 'includes/footer.php';
?>


