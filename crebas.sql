/*==============================================================*/
/* Nom de SGBD :  MySQL 5.0                                     */
/* Date de création :  28/02/2019 17:11:11                      */
/*==============================================================*/

/*==============================================================*/
/* Table : Client                                               */
/*==============================================================*/
create table Client
(
   code_client          int not null auto_increment  comment '',
   adresse              varchar(100)  comment '',
   num_tel              int  comment '',
   cin                  int  comment '',
   nom                  varchar(30)  comment '',
   prenom               varchar(30)  comment '',
   numpass              int  comment '',
   pays                 varchar(15)  comment '',
   code_fisc            int  comment '',
   raison               varchar(25)  comment '',
   primary key (code_client)
);

/*==============================================================*/
/* Table : Compte                                               */
/*==============================================================*/
create table Compte
(
   login                varchar(25) not null  comment '',
   mot_de_passe         varchar(25)  comment '',
   nom                  varchar(30)  comment '',
   prenom               varchar(30)  comment '',
   adresse_email        varchar(50)  comment '',
   num_tel              int  comment '',
   type					varchar(25) not null comment '',
   primary key (login)
);

/*==============================================================*/
/* Table : Contrat                                              */
/*==============================================================*/
create table Contrat
(
   num_contrat          int not null auto_increment  comment '',
   code_client          int not null  comment '',
   num_vehicule         int not null  comment '',
   tarif                int  comment '',
   avance               int  comment '',
   date_debut           date  comment '',
   date_fin             date  comment '',
   compteur_debut       int  comment '',
   compteur_fin         int  comment '',
   chauffeur            bool  comment '',
   primary key (num_contrat)
);

/*==============================================================*/
/* Table : Facture                                              */
/*==============================================================*/
create table Facture
(
   num_facture          int not null auto_increment  comment '',
   num_contrat          int not null  comment '',
   num_vehicule         int not null  comment '',
   categorie            varchar(25)  comment '',
   nb_km_hr             int  comment '',
   tarif_journalier     int  comment '',
   tarif_chauffeur      int  comment '',
   montant_global       int  comment '',
   montant_hors_taxe    int  comment '',
   montant_tva          int  comment '',
   montant_net          int  comment '',
   date_facture         date  comment '',
   primary key (num_facture)
);

/*==============================================================*/
/* Table : Tarif                                                */
/*==============================================================*/
create table Tarif
(
   categorie            varchar(25)  comment '',
   tarif_km             int  comment '',
   tarif_jour           int  comment '',
   tarif_heure          int  comment '',
   tarif_chauffeur      int  comment '',
   tarif_total          int  comment '',
   id_tarif             int not null auto_increment  comment '',
   primary key (id_tarif)
);

/*==============================================================*/
/* Table : Vehicule                                             */
/*==============================================================*/
create table Vehicule
(
   num_vehicule         int not null  comment '',
   matr                 int  comment '',
   marque               varchar(25)  comment '',
   categorie            varchar(25)  comment '',
   etat                 varchar(15)  comment '',
   nb_hr                int  comment '',
   nb_km                int  comment '',
   primary key (num_vehicule)
);

alter table Contrat add constraint FK_CONTRAT_ASSOCIATI_VEHICULE foreign key (num_vehicule)
      references Vehicule (num_vehicule) on delete restrict on update restrict;

alter table Contrat add constraint FK_CONTRAT_ASSOCIATI_CLIENT foreign key (code_client)
      references Client (code_client) on delete restrict on update restrict;

alter table Facture add constraint FK_FACTURE_ASSOCIATI_VEHICULE foreign key (num_vehicule)
      references Vehicule (num_vehicule) on delete restrict on update restrict;

alter table Facture add constraint FK_FACTURE_ASSOCIATI_CONTRAT foreign key (num_contrat)
      references Contrat (num_contrat) on delete restrict on update restrict;

