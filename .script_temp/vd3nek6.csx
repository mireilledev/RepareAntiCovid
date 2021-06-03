<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="utf-8">
    <title>Repare Anti-Covid</title>
    <link rel="preconnect" href="https://fonts.gstatic.com">
<link href="https://fonts.googleapis.com/css2?family=Source+Code+Pro:wght@400;600&display=swap" rel="stylesheet">
    <style>
        body {
          font-family: 'Source Code Pro', monospace;
          font-size: 16px;
        }
      </style>
</head>

<body>

    Réparons les qrcodes de Anti-Covid avec Mireille.<br />

    Que faire si votre qrcode est illisible ?<br />

    Sur votre feuille de vaccination vous avez deux code-barres :<br />
    <table>
        <tr>
            <td>
                Un semacode (data-matrix) à gauche :<br />
            </td>
            <td>
                Un qrcode à droite :<br />
            </td>
        </tr>
        <tr>
            <td>
                <img src="img/semacode_datamatrix.png" width="200" height="200">
            </td>
            <td>
                <img src="img/qrcode.png" width="200" height="200">
            </td>
        </tr>
    </table>

    Pour des raisons d'impression il peut arriver que le qrcode soit illisible.<br />


    Pour résoudre cela, scannez le contenu du semacode avec une application de scan de code barre.<br />


    Puis copiez le résultat dans le champs ci dessous.<br />


    Enfin vous aurez un qrcode a scanner sur l'application Anti-Covid tout neuf, tout beau.<br/>
<textarea id="semacode_covid" name="semacode_covid" rows="10" cols="100">
        Copiez le resultat du scan du semacode(datamatrix) ici.
</textarea>
    <br />
    <img id="qrcode_covid" src="">

</body>
<script src="js/repare.js"></script>

</html>