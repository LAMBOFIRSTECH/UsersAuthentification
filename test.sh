#!/bin/bash

# Définir le chemin d'accès complet au fichier script.py
script_path="$getPrivateGithubRepo/test.py"

# Exécuter le script en utilisant python3 avec le chemin d'accès complet
$(which python3) "$script_path"
echo $getPrivateGithubRepo
