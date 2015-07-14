Projet WindowsPhone : App de consultation des especes de fourmis
=================================================

##Introduction

Durant ma licence professionnel, j'ai eu l'occasion de développer en binôme une application mobile pour Windows Phone, le choix du sujet pour cette application n'était pas défini, et nous avons donc choisis de développer une application de consultation des différentes especes de fourmis existante a travers le monde.

##Différentes manières de trouver la fourmi que vous recherchez

L'écran d’accueil de l’application (voir schéma plus bas) rassemble les façons de rechercher des fourmis :
- Consulter toutes les fourmis disponibles sur la base de données sous forme de liste
- Un outil de recherche avancée (grâce à LINQ) :
• rechercher les fourmis dont le nom contient...
• rechercher les fourmis dont la taille est supérieure/inférieure à tant...
• rechercher les fourmis qui se trouvent dans le pays dont chaine de caractère est... • rechercher les fourmis dont un commentaire contient...
- Consulter les fourmis marquées comme Favoris
- Consulter une carte indiquant les zones où les différentes espèces de fourmis se
trouvent
- Consulter une espèce aléatoire

##La gestion des profils

L’application aura un système de profils utilisateurs. Cela permettra entre autres à
un utilisateur d’avoir une liste de Favoris, une liste de fourmis Déjà Vues, de poster des commentaires sur n’importe quelle fourmi...
Un profil est constitué d’un nom, d’une date de naissance, d’un mail, et d’une image (voir diagramme de classe).

##La carte

Une carte sera disponible et permettra de voir où se trouvent les différentes espèces de fourmis dans le monde. Un clic sur l’une d’elles renverra sur la page de l’espèce en question.
Deux types de Lieux seront possibles, un type classique « point » qui ciblera un point particulier de la carte, et un type « radius » qui ciblera une zone de la carte. Le clic sur une zone pourra renvoyer sur une une fourmi ou bien une liste de fourmis si plusieurs espèces se trouvent dans la zone.

##Le design

Concernant le design interne de l’application, nous utiliserons le système de tuiles de Microsoft, ainsi que l’interface « métro » pour le détail d’une fourmi.
