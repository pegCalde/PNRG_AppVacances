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
-> Why did you choose Xamarin technology? Explain in readme the advantages and disadvantages of Cross platform development according to lesson 1 and 2,  
comparing to natif and others cross platform solutions (Open GL ES, Web View).  


### avantages d'un dev cross plateforme xamarin



### inconvénients d'un dev cross plateforme xamarin



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

pr que l'utilisateur ai une page profil user à voir  

### Barre de nav

Page accueil  
Page détails du lieu  
Page favoris  
btn déco

## Maquette

...

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
* menu = nav par onglets en bas
   * Page accueil
   * Page détails infos lieu choisi
   * Liste favoris
* Remplissage du ReadMe
* Maquette
* PowerPoint présentation projet
* ...

## Ressources

API météo
https://openweathermap.org

## ...
