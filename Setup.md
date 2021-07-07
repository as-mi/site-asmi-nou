# Setup tehnic :hammer_and_wrench:
1. [Instalare Visual Studio și ASP.NET 5](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#visual-studio-fleur_de_lis).
2. [Pașii de lucru și recomandări](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#pașii-de-lucru-gear).

## Visual Studio :fleur_de_lis:
- ASP.NET 5 este disponibil pentru versiunile de Visual Studio >= 2019. 
- [Download Visual Studio Community 2019](https://visualstudio.microsoft.com/vs/).


### ASP.NET 5
- ASP.NET 5 are nevoie să fie instalate pe Visual Studio următoarele:

#### Workloads Tab
<img src="https://user-images.githubusercontent.com/61749814/124249191-4f468e00-db2c-11eb-9d81-339edd6550f2.JPG" width="1000" height="550">
<img src="https://user-images.githubusercontent.com/61749814/124249193-4fdf2480-db2c-11eb-9f46-4e78741a7b5c.JPG" width="1000" height="550">

#### Individual Components Tab
<img src="https://user-images.githubusercontent.com/61749814/124249196-5077bb00-db2c-11eb-94cf-6a54ded01775.JPG" width="1000" height="550">
<img src="https://user-images.githubusercontent.com/61749814/124249199-5077bb00-db2c-11eb-89a3-d8aa4bd09c11.JPG" width="1000" height="550">

## Pașii de lucru :gear:
- *Dacă NU ai mai lucrat la proiect* 

➡️ Dacă contribui pentru prima oară la dezvoltarea proiectului, găsești aici [Instrucțiunile pentru instalarea GitHub și descărcarea proiectului local](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#toolbox-descărcare-proiect).

:mage_man: *Recomandare:* deschide proiectul dând click pe ``` ASMI.sln ``` din folderul proietului, <b> NU </b> deschizând mai intâi Visual Studio, iar apoi folosind Tabul File -> Open, deoarece nu merge întotdeauna rulat proiectul cu această metodă. 

- *Dacă ai mai lucrat la proiect* 

➡️ Ai grijă să lucrezi pe utlima versiune a proiectului, dacă alți colegi au făcut modificări în branch-ul ```main```. Găsești aici [Instrucțiunile pentru actualizarea proiectului deja aflat local](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#toolbox-actualizare-versiune-proiect-local).

➡️ Este recomandat ca fiecare contribuitor să folosească un branch separat. Cand termini un set de modificări, vei da ```merge``` cu branch-ul main. Găsești aici [Instrucțiunile pentru crearea unui branch nou și încarcarea modificărilor pe Git-ul ASMI](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#toolbox-creare-branch-nou-și-încărcare-modificări-pe-git-ul-asmi) și [Instrucțiunile pentru merging cu branch-ul main]().

### :toolbox: Descărcare proiect 

*Dacă nu îl ai deja descărcat local*
1. Instalează [Git pentru PC](https://git-scm.com/downloads).
2. Crează un folder local.
3. Deschide un terminal de Git Bash.
<img src="https://user-images.githubusercontent.com/61749814/124256376-e400ba00-db33-11eb-8966-ac61811dafe0.png" width="700" height="550">

4. Introduce comanda:
   ```git clone https://github.com/as-mi/site-asmi-nou.git``` 
<img src="https://user-images.githubusercontent.com/61749814/124256382-e531e700-db33-11eb-8ac8-55839735492e.JPG" width="850" height="600">

### :toolbox: Actualizare versiune proiect local 

*Dacă îl ai deja descarcat local*
1. Deschide folderul rezultat în urma clonării ```site-asmi-nou```.
2. Deschide Git Bash în el.
3. Introduce comanda ```git pull --rebase https://github.com/as-mi/site-asmi-nou.git```.

*PS: Să ai grijă să fii mereu pe branch-ul pe care vrei să lucrezi.* 

### :toolbox: Creare branch nou și încărcare modificări pe Git-ul ASMI
1. Deschide folderul rezultat iîn urma clonării ```site-asmi-nou```.
2. Deschide Git Bash în el.

*Dacă ai deja creat branch-ul (și local și online) sari la pasul 5*

4. Crează un nou branch prin comanda ``` git branch nume_branch```.
5. Mută-te pe noul branch prin comanda ``` git checkout nume_branch```.
6. Ar trebui să se schimbe numele noului branch în linia de comandă.
7. Incarcă modificările pe branch prin comanda ``` git add . ```.
8. Adaugă un mesaj care va fi afișat la încărcarea pe Git ```git commit -m "mesajul tău"```.
9. Incarcă noile modificari pe noul branch ```git push origin -f nume_branch```.

### :toolbox: Merging in branch-ul main
1. Mută-te pe branch-ul main: ``` git checkout main```.
2. Merging cu branch-ul main: ``` git merge nume_branch_modificat```.
3. Incarcă modificările combinate (main + cele făcute de tine local) pe Git-ul ASMI: ``` git push origin -f main```.


### *:eight_pointed_black_star: Pentru ajutor dm: @Oana @Motanu :eight_pointed_black_star:*
