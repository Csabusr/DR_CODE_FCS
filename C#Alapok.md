﻿# C#Alapok

## Fontos tudnivalók

### Mik a fontos karakterek a c#-ban?


| Jel, Karakter | Felhasználása|
|------------------------|----------------------|
|<p align="center"> ; </p>| <p align="center">Lezár egy utasítást</p> |
|<p align="center"> { </p>| <p align="center">Utasítás sorozat kezdete ( BEGIN )</p> |
|<p align="center"> } </p>| <p align="center">Utasítás sorozat vége ( END )</p> |
|<p align="center"> ( ) </p>| <p align="center">Utasítások csoportosítására szolgál ( Console.WriteLine(); )</p> |
|<p align="center"> = </p>| <p align="center">Értékadás ( a = 43 )</p> |
|<p align="center"> "Ez a szöveg" </p>| <p align="center">Szöveg határolók ( Ez a szöveg )</p> |
|<p align="center"> 'A' </p>| <p align="center">Karakter határolók ( A )</p> |
|<p align="center"> // </p>| <p align="center">Kommentelés</p> |


## 

### Típusok

| Hívószó | Típusfajta|
|------------------------|----------------------|
|<p align="center"> int </p>| <p align="center">Egész szám típus ( 1234 )</p> |
|<p align="center"> string </p>| <p align="center">Szöveges típus ( "SZÖVEG" )</p> |
|<p align="center"> bool </p>| <p align="center">Logikai típus ( igen, nem )</p> |
|<p align="center"> double </p>| <p align="center">Lebegőpontos szám típus ( 12.1584 )</p> |
|<p align="center"> char </p>| <p align="center">Karakter típus ( 'c' )</p> |



### Alap parancsok

| Parancs | Funkció |
|------------------------|----------------------|
|<p align="center"> WriteLine() </p>| <p align="center">Kiíratás</p> |
|<p align="center"> ReadLine() </p>| <p align="center">Beolvasás</p> |
|<p align="center"> tipus.Parse() </p>| <p align="center">Típus konvertálás</p> |
|<p align="center"> (int) a </p>| <p align="center">Típus kényszerítés</p> |

### Operátorok 
| Operátor | Funkció |
|------------------------|----------------------|
| <p align="center"> + </p> | <p align="center"> Összeadás </p> |
| <p align="center"> - </p> | <p align="center"> Kivonás </p> |
| <p align="center"> * </p> | <p align="center"> Szorzás </p> |
| <p align="center"> % </p> | <p align="center"> Maradék nélküli osztás </p> |
| <p align="center"> / </p> | <p align="center"> Maradékos osztás </p> |  
| <p align="center"> &#124;&#124; </p> | <p align="center"> Logikai VAGY operátor </p> |  
| <p align="center"> && </p> | <p align="center"> Logikai ÉS operátor </p> | 
|<p align="center"> == </p>| <p align="center">Logikai Operátor ( Egyenlő )</p> |
|<p align="center"> != </p>| <p align="center">Logikai Operátor ( Nem Egyenlő )</p> |
|<p align="center"> < és > </p>| <p align="center">Relációjelek ( Nagyobb )</p> |


## Elágazás opciók  
### IF

<hr></hr>

* #### If (feltétel;) Parancs1; 
* #### If (feltétel;) {Parancs1; Parancs2; Parancsn;}

<hr></hr>

* #### If (feltétel;) Parancs1; 
    #### Else Parancs1;
* #### If (feltétel;) {Parancs1; Parancs2; Parancsn;}   
    #### Else {Parancs1; Parancs2; Parancsn;}
    
**Else = különben* 

<hr></hr>  

### Switch Case

* #### Swicth(feltétel)
     #### case 'teljesül': Parancso1; or ParancsN; break;

## Ciklusok

### Kötött lépésszámú  
  
for(int i=0; i < lépésszám; i++;)
{
    parancs1; or parancsN;
}

### Elöltesztelős ciklus amíg igaz fut (while)

while(feltétel)
{ 
    parancs1; or parancsN;
}

### Elöltesztelős ciklus amíg hamis fut (do, while)

do
{ 
    parancs1; or parancsN;
} while(feltétel)

### Foreach

foreach(típus név in összetett adatszerkezet)
{
    parancs1; or parancsN;
}



