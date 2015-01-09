<?php session_start(); ?>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Потребителска страница</title>
    <meta charset="utf-8" />
    <style>
        div {
            margin: 50px;
        }

            div a {
                width: 100px;
                height: 30px;
                color: white;
                background: #b7deed; /* Old browsers */
                background: -moz-linear-gradient(top, #b7deed 0%, #71ceef 50%, #21b4e2 51%, #b7deed 100%); /* FF3.6+ */
                background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,#b7deed), color-stop(50%,#71ceef), color-stop(51%,#21b4e2), color-stop(100%,#b7deed)); /* Chrome,Safari4+ */
                background: -webkit-linear-gradient(top, #b7deed 0%,#71ceef 50%,#21b4e2 51%,#b7deed 100%); /* Chrome10+,Safari5.1+ */
                background: -o-linear-gradient(top, #b7deed 0%,#71ceef 50%,#21b4e2 51%,#b7deed 100%); /* Opera 11.10+ */
                background: -ms-linear-gradient(top, #b7deed 0%,#71ceef 50%,#21b4e2 51%,#b7deed 100%); /* IE10+ */
                background: linear-gradient(to bottom, #b7deed 0%,#71ceef 50%,#21b4e2 51%,#b7deed 100%); /* W3C */
                filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#b7deed', endColorstr='#b7deed',GradientType=0 ); /* IE6-9 */
                border: 1px solid black;
                border-radius: 15px;
                padding: 10px;
                margin: 20px;
                text-decoration: none;
                font-size: 20px;
            }


                div a:hover {
                    background: #d0e4f7; /* Old browsers */
                    background: -moz-linear-gradient(top, #d0e4f7 0%, #73b1e7 24%, #0a77d5 50%, #539fe1 79%, #87bcea 100%); /* FF3.6+ */
                    background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,#d0e4f7), color-stop(24%,#73b1e7), color-stop(50%,#0a77d5), color-stop(79%,#539fe1), color-stop(100%,#87bcea)); /* Chrome,Safari4+ */
                    background: -webkit-linear-gradient(top, #d0e4f7 0%,#73b1e7 24%,#0a77d5 50%,#539fe1 79%,#87bcea 100%); /* Chrome10+,Safari5.1+ */
                    background: -o-linear-gradient(top, #d0e4f7 0%,#73b1e7 24%,#0a77d5 50%,#539fe1 79%,#87bcea 100%); /* Opera 11.10+ */
                    background: -ms-linear-gradient(top, #d0e4f7 0%,#73b1e7 24%,#0a77d5 50%,#539fe1 79%,#87bcea 100%); /* IE10+ */
                    background: linear-gradient(to bottom, #d0e4f7 0%,#73b1e7 24%,#0a77d5 50%,#539fe1 79%,#87bcea 100%); /* W3C */
                    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#d0e4f7', endColorstr='#87bcea',GradientType=0 ); /* IE6-9 */
                }
    </style>
</head>
<body>
    <a href="upload.php">Качи файл</a>
    <a href="files.php">Файлове</a>
</body>
</html>