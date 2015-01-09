<?php
	mb_internal_encoding('UTF-8');
	$pageTitle = 'Форма';
    include 'includes/header.php';
	
	if ($_POST) {
		$name = trim($_POST['name']);
		$name = str_replace('|', '', $name);
		$phone = trim($_POST['phone']);
		$phone = str_replace('|', '', $phone);
		$name = trim($_POST['name']);
		$group = (int)$_POST['group'];
		$error = FALSE;
		
		if (mb_strlen($name) < 4) {
			echo "<p>Името е по-малко от 4 символа. Опитайте отново! </p>";
			$error = TRUE;
		}
		
		if (mb_strlen($phone) < 4 && mb_strlen($phone) > 12) {
			echo "<p>Номерът е грешен</p>";
			$error = TRUE;
		}
		
		if (!array_key_exists($group, $groups)) {
			echo '<p>Невалидна група</p>';
			$error = TRUE;
		}
		
		if (!$error) {
			$result = $name.'|'.$phone.'|'.$group."\n";
			if (file_put_contents('data.txt', $result, FILE_APPEND)) {
				
				echo "Контакта е създаден успешно! ";
			}
			
		}
	}
?>
<div id="wrapper">
<form method="post">
	<fieldset>
            <legend>  add contact  </legend>
        <label for="name">Name: </label>
        <input type="text" name="name" id='name' placeholder="Enter name: " /><br/>
        <label for="phone">Phone: </label>
        <input type="tel" name="phone" id='phone' placeholder="Enter number: " /><br/>
        <label for="group">Group: </label>
        <select name="group" id='group'>
            <?php 
            foreach ($groups as $key => $value) {
                echo '<option value="'.$key.'">'.$value.'</option>';
            }
                
            ?>
            
        </select>
        </fieldset>
        <div class='btn'>
        	<a href="index.php">List</a>
        </div>
        
        <input type="submit" name="submit" id="submit" value="Add"/>
    </form>
</div>
<?php
	include 'includes/footer.php';
?>