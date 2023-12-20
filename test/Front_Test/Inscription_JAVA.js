function validateForm(event) {
    event.preventDefault(); // Empêche le formulaire de soumettre les données automatiquement

    // Récupère les valeurs du formulaire
    var username = document.getElementById('username').value;
    var email = document.getElementById('email').value;
    var password = document.getElementById('password').value;
    var confirmPassword = document.getElementById('confirmPassword').value;

    // Valide si les champs ne sont pas vides
    if (username === '' || email === '' || password === '' || confirmPassword === '') {
        alert('Tous les champs doivent être remplis.');
        return;
    }

    // Valide si les mots de passe correspondent
    if (password !== confirmPassword) {
        alert('Les mots de passe ne correspondent pas.');
        return;
    }

    // Autres validations peuvent être ajoutées ici...

    // Si tout est valide, vous pouvez soumettre les données au serveur ou effectuer d'autres actions nécessaires
    alert('Inscription réussie !');
}