# PNRG_AppVacances

## Membres du groupe

Peggy Calderon-Kayser  
Nawel Aittahar  
Raoua Messai  
Guillaume Savin

## CdC
Techno xamarin en c#/xaml  
Application de Lieu de vacances  

Cette application permet à l’utilisateur de consulter différents lieux de vacances et d’accéder aux informations de chaque lieu, ensuite il peut ajouter des lieux à sa liste de favoris et ajouter une note personnelle au lieu via un système de notation à étoile.  

* Persistance de certaines données : 
  * La note de l’utilisateur pour un lieu
  * les favoris
  * la notation d'un lieu

* Utilisation d’une navigation avancée :  
    * Main page = la liste des lieux de vacances  
    * Page liste de lieu favoris
    * Page Détails du lieu  
    * ...

Nécessite l'utilisation :
* d'un serveur
* d'une base de données  
* d'une API
* d'un dependency service

Utilisation d’une API externe pour la météo : OpenWeatherMap (donner des informations de météo sur le lieu de vacances)  

## Pourquoi xamarin ?

Xamarin est 100% plateformes mobiles et ne necessite pas d'apprendre un langage spécifique à chaque OS mobile. Ca permet d’écrire du code autant pour iOS que pour Android ou Windows mobile avec un seul langage (le c#).  
Comme nous avions un peu plus d'expérience avec ce langage (c#) et ce framework (xamarin) par rapport à d'autres, nous avons préféré approfondir ces connaissances plutôt que de 
repartir sur une technologie et un langage que nous maitrisions moins parce que peu de connaissances.  
Notre application n'ayant pas de graphique lourd, xamarin était un bon choix également pour cette raison.  

### avantages d'un dev cross plateforme xamarin

Par rapport aux app native qui permettent de développer sur un périphérique dédié, un android ne fonctionnera pas sur ios et inversement, xamarin permet de développer pour plusieurs périphériques sans soucis de langage.  

### inconvénients d'un dev cross plateforme xamarin

 Il peut être compliqué d'utiliser toutes les bibliothèques open-source parce que Xamarin, même si il prend en charge la plupart des bibliothèques .Net, ne prend pas en charge toutes les bibliothèques tierces disponibles pour Android et iOS sans wrappers spécifiques.  
 Ne convient pas aux applications ayant des graphiques lourds (ce qui n'est pas le cas pour notre application puisque les graphiques sont légers).  
 Pour une application ayant une UX / UI riche , il faut obligatoirement l'implémenter de manière native.  
 Taille de l'application plus grande est plus grande avec Xamarin ouisqu'il ajoute 3 à 5 mégaoctets pour la version et environ 20 mégaoctets pour les versions de débogage.

## Tâches

* structure -> MVVM
* menu = nav par onglets en bas
* Listes : 
   * favoris  
     * Système de mise en favoris
   * lieux  
     * Au clic sur lieu -> envoi sur la page du lieu pour voir les détails du lieu (infos, temps, photos,...)
   * users
     * plusieurs utilisateurs 
* Connexion à l'API météo OpenWeatherMap
   * Création d'une fonction d'appel à l'API
   * Connexion avec le front
   * Récupération de la température du lieu
   * Récupération de la météo du lieu sur qq jours -> icônes
* Persistance des données
* Système de notation du lieu -> par étoiles
* Possibilité pour l'utilisateur de rajouter des lieux => save ds bdd
* Page de login
* Page de profil user ???
* Serveur => MongoDb
* API maison A VOIR
* Création partie user sur page accueil -> nom + img profil + img de couverture
* "Caroussel" img de lieu -> 3 img max avec flèches droite-gauche 
* Recherches pour remplissage infos des lieux 
   * img du lieu
   * 3 img max des lieux à voir ds le lieu (caroussel)
   * Nom du lieu
   * différentes infos diverses sur lieu 
* PowerPoint présentation projet
* Vidéo de présentation de l'application + démo de l'app 
* ...

## Pages

### Page login

pseudo  
mdp  
mdp oublié ???  

### Page accueil

* infos user :
  * nom/pseudo
  * img profil
  * img couv
* liste de lieux
* possibilité de voir les profils des autres utilisateurs

### Page détails du lieu

photos  
temps => température, icône du tps  
texte descriptif du lieu  
possibilité de mettre en favoris  
possibilité de noter le lieu  

### Page favoris

liste des lieux mis en favoris => possibilité de retirer un lieu des favoris

### Page user ????

pr que l'utilisateur ait une page profil user à voir  

### Barre de nav

Page accueil  
Page détails du lieu  
Page favoris  
btn déco

## Maquette

![login](https://user-images.githubusercontent.com/50577515/117687163-ceb48280-b1b7-11eb-9d75-0e99f6be00fd.png)  
![pageAccueil-listeLieuxAvisiter](https://user-images.githubusercontent.com/50577515/117687688-500c1500-b1b8-11eb-8647-400de76ad6ea.png)  
![listeFavoris](https://user-images.githubusercontent.com/50577515/117688028-b002bb80-b1b8-11eb-89e0-da5c2edc7f5d.png)  



## Répartition

### Guillaume
* Structure du code
* Persistance des données 
* Création partie user sur page accueil -> nom + img profil + img de couverture
*  Liste des lieux 
   * Au clic sur lieu -> envoi sur la page de détail du lieu
* serveur mongoDb
* API maison
* PowerPoint présentation projet
* ...

### Nawel
* Création user/view model/model/view
* Liste de favoris
   * Possibilité de supprimer lieu
* Afficher élément au clic
* liste de user
* PowerPoint présentation projet
* ...

### Raoua
* Page détails du lieu
* Système de notation du lieu -> par étoiles
* Connexion à l'API météo OpenWeatherMap
   * Création d'une fonction d'appel à l'API
   * Connexion avec le front
   * Récupération de la température du lieu
   * Récupération de la météo du lieu sur qq jours -> icônes
* système de notation du lieu
* "Caroussel" img de lieu -> 3 img max avec flèches droite-gauche
* PowerPoint présentation projet
* ...

### Peggy
* Dependancy Service Photo Picker
* Recherches pour remplissage infos des lieux
   * img du lieu
   * 3 img max des lieux à voir ds le lieu
   * Nom du lieu
   * différentes infos diverses sur lieu 
* menu pr la nav
   * Page accueil
   * Page détails infos lieu choisi
   * Liste favoris
* Remplissage du ReadMe
* PowerPoint présentation projet
* ...

## Ressources

API météo  
https://openweathermap.org

Naming convention  
https://gitlab.com/chillcoding-at-the-beach/kotlin-for-android/-/wikis/Naming-Convention

## ...
