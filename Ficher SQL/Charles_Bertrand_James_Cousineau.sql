drop view AfficherTousLesCircuits;
drop view AfficherCircuitVilleDepart;
drop view AfficherCircuitNbEtoiles;
drop view AfficherCircuitContraintePrix;
drop view AfficherMeilleurCircuit;
drop  sequence seq_Monuments;
drop sequence seq_Circuit;
drop table CircuitMonuments;
drop table Monuments;
drop table ReservationsCircuits;
drop table Circuit;
drop table Réservations;
drop table Clients;
drop table ville;

CREATE TABLE CircuitMonuments
  (
    IdMonument  NUMBER (3) NOT NULL ,
    NomCircuit  VARCHAR2 (30) NOT NULL ,
    ordredeVisite NUMBER (2)
  ) ;


CREATE TABLE Circuit
  (
    NomCircuit       VARCHAR2 (30) NOT NULL ,
    Prix             NUMBER (6,2) ,
    Durée            NUMBER (3) ,
    CodeVilleDepart  CHAR (3) NOT NULL ,
    CodeVilleArrivée CHAR (3) NOT NULL
  ) ;



CREATE TABLE Clients
  (
    IdClient  NUMBER (4) NOT NULL ,
    NomClient VARCHAR2 (30) ,
    Prenom    VARCHAR2 (30) ,
    Adresse   VARCHAR2 (40)
  ) ;


CREATE TABLE Monuments
  (
    IdMonument NUMBER (3) NOT NULL ,
    Nom        VARCHAR2 (30) ,
    DateDeCreation     DATE ,
    Histoire   VARCHAR2 (100) ,
    NbEtoiles  NUMBER (1) NOT NULL
  ) ;
 

CREATE TABLE ReservationsCircuits
  (
    NomCircuits   VARCHAR2 (30) NOT NULL ,
    IdReservation NUMBER (4) NOT NULL
  ) ;



CREATE TABLE Réservations
  (
    IdReservation   NUMBER (4) NOT NULL ,
    DateReservation DATE ,
    DateLimite      DATE ,
    IdClient        NUMBER (4) NOT NULL
  ) ;


CREATE TABLE Ville
  (
    CodeVille   CHAR (3) NOT NULL ,
    NomVille    VARCHAR2 (30) ,
    NbHabitants NUMBER (9) ,
    Histoire    VARCHAR2 (100)
  ) ;
  
  
  




ALTER TABLE Clients ADD CONSTRAINT Clients_PK PRIMARY KEY ( IdClient ) ;

ALTER TABLE Ville ADD CONSTRAINT Villes_PK PRIMARY KEY ( CodeVille ) ;

ALTER TABLE Circuit ADD CONSTRAINT FK1Circuit FOREIGN KEY ( CodeVilleDepart ) REFERENCES Ville ( CodeVille ) ;

ALTER TABLE Circuit ADD CONSTRAINT FK2Circuit FOREIGN KEY ( CodeVilleArrivée ) REFERENCES Ville ( CodeVille ) ;

alter table circuit add  check(prix >= 50);

ALTER TABLE Circuit ADD CONSTRAINT Circuits_PK PRIMARY KEY ( NomCircuit ) ;

ALTER TABLE circuit ADD NumeroSequntiel number(7);

ALTER TABLE Monuments ADD GUID VARCHAR2(100);

alter table monuments add check (NbEtoiles >= 1 and NbEtoiles <= 5);
 
ALTER TABLE Monuments ADD CONSTRAINT Monuments_PK PRIMARY KEY ( IdMonument ) ;

ALTER TABLE CircuitMonuments ADD CONSTRAINT CircuitMonuments_PK PRIMARY KEY ( IdMonument, NomCircuit ) ;

alter table CircuitMonuments

add constraint CircuitMonumentsFK1  FOREIGN KEY ( NomCircuit ) REFERENCES Circuit ( NomCircuit ) on delete cascade;

alter table CircuitMonuments

ADD CONSTRAINT CircuitMonumentsFK2 FOREIGN KEY ( IdMonument ) REFERENCES Monuments ( IdMonument )on delete cascade;


ALTER TABLE Réservations ADD CONSTRAINT RéservationsFK FOREIGN KEY ( IdClient ) REFERENCES Clients ( IdClient ) ;--

ALTER TABLE Réservations ADD CONSTRAINT Réservations_PK PRIMARY KEY ( IdReservation ) ;

ALTER TABLE ReservationsCircuits ADD CONSTRAINT ReservationCicruitsFK1 FOREIGN KEY ( NomCircuits ) REFERENCES Circuit ( NomCircuit ) ;

ALTER TABLE ReservationsCircuits ADD CONSTRAINT ReservationsCircuits_PK PRIMARY KEY ( NomCircuits, IdReservation ) ;

ALTER TABLE ReservationsCircuits ADD CONSTRAINT ReservationCicruitsFK2 FOREIGN KEY ( IdReservation ) REFERENCES Réservations ( IdReservation ) ;







--Insertion
--Villes
insert into ville values( 'BLV' ,'Blainville' , 1000 , 'Histoire de la ville de Blainville'); 
insert into ville values( 'S-T' ,'Sainte-Thérèse' , 1000 , 'Histoire de la ville de Sainte-Thérèse'); 
insert into ville values ('S-J' , 'Saint-Jérome' , 500 , 'Histoire de la ville de Saint-Jérome');
insert into ville values ('MTL' , 'Montréal' , 50000 , 'Histoire de la ville de Montréal');
insert into ville values ('MRB' , 'Mirabel' , 6000 , 'Histoire de la ville de Mirabel');
insert into ville values ('BB' , 'Boisbriand' , 700 , 'Histoire de la ville de Boisbriand');
insert into ville values ('S-E' , 'Saint-Eustache' , 500000 , 'Histoire de la ville de Saint-Eustache');
insert into ville values ('LV' , 'Laval' , 3000 , 'Histoire de la ville de Laval');
commit;

--Circuits
insert into circuit values('Circuit A' , 50, 100 ,'BLV' ,'S-T' , 1);
insert into circuit values('Circuit B' , 100, 200 ,'S-J' ,'MTL' , 2);
insert into circuit values('Circuit C' , 200, 350 ,'MTL' ,'MRB' , 3);
insert into circuit values('Circuit D' , 400, 800 ,'BB' ,'S-E' , 4);
insert into circuit values('Circuit E' , 800, 75 ,'LV' ,'BLV' , 5);
commit;

--Monument
insert into monuments values(1, 'Parc du domaine Vert' , TO_DATE('1989-12-09','YYYY-MM-DD') , 'Forested site with a ski school, pool and kids camps for sports, activities and wildlife-watching' , 4 , null);
insert into monuments values(2, '123 GO' , TO_DATE('2010-06-19','YYYY-MM-DD') , 'Sizable indoor play space featuring ball pits and slides, with birthday party packages available.' , 4 , null );
insert into monuments values(3, 'Jardin de la Vieille Grange' , TO_DATE('1989-12-09','YYYY-MM-DD') , 'Forested site with a ski school, pool and kids camps for sports, activities and wildlife-watching' , 4 , null );
insert into monuments values(4, 'Parc Claude-Henri Grignon' , TO_DATE('2001-01-03','YYYY-MM-DD') , ' A really great park suitable for all age groups of children! ' , 3 , null);
insert into monuments values(5, 'Parc Ducharme' , TO_DATE('1999-11-19','YYYY-MM-DD') , ' Nice for a walk at the end of a hard day ' , 3 , null );
insert into monuments values(6, 'Maurice-Tessier' , TO_DATE('2001-12-09','YYYY-MM-DD') , 'Many varied infrastructures, located in the heart of the civic pole of the city.' , 4 , null);
insert into monuments values(7, 'Park Bolivars' , TO_DATE('2005-02-22','YYYY-MM-DD') , 'There is some bug' , 2  , null);
insert into monuments values(8, 'Lacs Fauvel' , TO_DATE('1970-08-28','YYYY-MM-DD') , 'It is a place in the middle of nature and this very close to the city.' , 5  , null);
insert into monuments values(9, 'Cimetière' , TO_DATE('1897-12-09','YYYY-MM-DD') , 'Beautiful, rather quiet site' , 1 , null );
insert into monuments values(10, 'Maison Lachaine' , TO_DATE('1980-05-06','YYYY-MM-DD') , 'Pretty ancestral house.' , 4 , null );
insert into monuments values(11, 'Sentier de poésie' , TO_DATE('2012-01-25','YYYY-MM-DD') , ' le Sentier de poésie est un lieu inspirant mettant en valeur la poésie québécoise.' , 5 , null );
insert into monuments values(12, 'Montmorency Falls' , TO_DATE('2018-12-15','YYYY-MM-DD') , 'Great place to walk around and beautiful scenery, day and night!' , 5 , null );
insert into monuments values(13, 'Le Château Frontenac' , TO_DATE('1993-06-14','YYYY-MM-DD') , ' historic hotel in Quebec City' , 2  , null);
insert into monuments values(14, 'Musée de la civilisation' , TO_DATE('1988-12-19','YYYY-MM-DD') , 'designed by architect Moshe Safdie' , 1 , null);
insert into monuments values(15, 'Aquarium du Québec' , TO_DATE('1959-03-15','YYYY-MM-DD') , 'The 16-hectare facility is home to more than 10,000 animals representing more than 300 species' , 3  , null);
insert into monuments values(16, 'test' , TO_DATE('1989-12-09','YYYY-MM-DD') , 'Forested site with a ski school, pool and kids camps for sports, activities and wildlife-watching' , 4 , null);
commit;

--CircuitMonument
--CircuitA
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(1, 'Circuit A', 1);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(2, 'Circuit A', 2);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(3, 'Circuit A', 3);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(4, 'Circuit A', 4);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(5, 'Circuit A', 5);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(16, 'Circuit A', 6);
commit;

--Circuit B
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(6, 'Circuit B', 1);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(7, 'Circuit B', 2);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(8, 'Circuit B', 3);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(9, 'Circuit B', 4);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(10,'Circuit B', 5);
commit;

--Circuit C
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(11, 'Circuit C', 1);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(12, 'Circuit C', 2);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(13, 'Circuit C', 3);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(14, 'Circuit C', 4);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(15, 'Circuit C', 5);
commit;

--Circuit D
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(2, 'Circuit D', 1);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(4, 'Circuit D', 2);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(8, 'Circuit D', 3);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(1, 'Circuit D', 4);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(3, 'Circuit D', 5);
commit;

--Circuit E
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(15, 'Circuit E', 1);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(10, 'Circuit E', 2);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(5, 'Circuit E', 3);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(1, 'Circuit E', 4);
insert into circuitmonuments(IdMonument ,NomCircuit ,ordredeVisite ) values(8, 'Circuit E', 5);
commit;







--8. Quels est le meilleur circuit (d’abord selon le coût, puis selon le nombre de
--monuments de trois étoiles ou plus) à choisir pour visiter un monument en
--particulier.

select * from (
select circuit.nomcircuit , prix , count(*) as nbmonumentAyant3EtoilesEtPlus  from (( circuitmonuments inner join monuments on circuitmonuments.idmonument= monuments.idmonument)
inner join circuit on circuitmonuments.nomcircuit=circuit.nomcircuit) where nbetoiles >= 3
group by circuit.nomcircuit , prix order by prix);

/*CREATE VIEW MeilleurCircuit AS
select circuit.nomcircuit , prix , count(*) as nbmonumentAyant3EtoilesEtPlus  from (( circuitmonuments inner join monuments on circuitmonuments.idmonument= monuments.idmonument)
inner join circuit on circuitmonuments.nomcircuit=circuit.nomcircuit) where nbetoiles >= 3
group by circuit.nomcircuit , prix order by prix;*/




/*select * from ville;
select * from circuit;
select * from circuitmonuments;
select * from monuments;*/

create sequence seq_Circuit
minvalue 1
start with 20
increment by 1;
commit;

create sequence seq_Monuments
minvalue 1
start with 16
increment by 1;



/* Good */
CREATE VIEW AfficherTousLesCircuits AS
SELECT DISTINCT C.NOMCIRCUIT, V.NOMVILLE AS DEPART, V2.NOMVILLE AS ARRIVEE, C.PRIX AS PRICE
FROM CIRCUITMONUMENTS CM
RIGHT JOIN CIRCUIT C ON C.NOMCIRCUIT = CM.NOMCIRCUIT
INNER JOIN VILLE V ON C.CODEVILLEDEPART = V.CODEVILLE
INNER JOIN VILLE V2 ON C.CODEVILLEARRIVéE = V2.CODEVILLE;

/* Good */
CREATE VIEW AfficherCircuitVilleDepart AS
SELECT DISTINCT C.NOMCIRCUIT, V.NOMVILLE AS DEPART, C.PRIX
FROM CIRCUIT C
INNER JOIN CIRCUITMONUMENTS CM ON C.NOMCIRCUIT = CM.NOMCIRCUIT
INNER JOIN VILLE V ON C.CODEVILLEDEPART = V.CODEVILLE;

/* Good */
CREATE VIEW AfficherCircuitContraintePrix AS
SELECT DISTINCT C.NOMCIRCUIT, V.NOMVILLE AS DEPART, V2.NOMVILLE AS ARRIVEE, C.PRIX
FROM CIRCUIT C
INNER JOIN CIRCUITMONUMENTS CM ON C.NOMCIRCUIT = CM.NOMCIRCUIT
INNER JOIN VILLE V ON C.CODEVILLEDEPART = V.CODEVILLE
INNER JOIN VILLE V2 ON C.CODEVILLEARRIVéE = V2.CODEVILLE;

/* Good */
CREATE VIEW AfficherCircuitNbEtoiles AS
SELECT DISTINCT C.NOMCIRCUIT, V.NOMVILLE AS DEPART, V2.NOMVILLE AS ARRIVEE, ROUND(AVG(M.NbEtoiles)) AS NbEtoiles
FROM MONUMENTS M
INNER JOIN CIRCUITMONUMENTS CM ON M.IDMONUMENT = CM.IDMONUMENT
INNER JOIN CIRCUIT C ON CM.NOMCIRCUIT = C.NOMCIRCUIT
INNER JOIN VILLE V ON C.CODEVILLEDEPART = V.CODEVILLE
INNER JOIN VILLE V2 ON C.CODEVILLEARRIvéE = V2.CODEVILLE group by C.NOMCIRCUIT, V.NOMVILLE, V2.NOMVILLE order by NbEtoiles desc;

/* Good */
CREATE VIEW AfficherMeilleurCircuit AS
SELECT C.NOMCIRCUIT, PRIX, COUNT(*) AS TEST
FROM CIRCUITMONUMENTS CM
INNER JOIN MONUMENTS M ON CM.IDMONUMENT = M.IDMONUMENT
INNER JOIN CIRCUIT C ON CM.NOMCIRCUIT = C.NOMCIRCUIT
WHERE NBETOILES >= 3 GROUP BY C.NOMCIRCUIT, PRIX ORDER BY PRIX;

select  C.NOMCIRCUIT, COUNT(*)
FROM CIRCUITMONUMENTS CM
INNER JOIN MONUMENTS M ON CM.IDMONUMENT = M.IDMONUMENT
INNER JOIN CIRCUIT C ON CM.NOMCIRCUIT = C.NOMCIRCUIT
GROUP BY C.NOMCIRCUIT;