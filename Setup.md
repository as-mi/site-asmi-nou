# Setup tehnic :hammer_and_wrench:
1. [Instalare Visual Studio și ASP.NET 5](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#visual-studio-fleur_de_lis).
2. [Pași de lucru și recomandări](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#pașii-de-lucru-gear).

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

- *Dacă ai mai lucrat la proiect* 

➡️ Ai grijă să lucrezi pe utlima versiune a proiectului, dacă alți colegi au făcut modificări în branch-ul ```main```. Găsești aici [Instrucțiunile pentru actualizarea proiectului deja aflat local](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#toolbox-actualizare-versiune-proiect-local).

➡️ Este recomandat ca fiecare contribuitor să folosească un branch separat. Cand termini un set de modificări, vei da ```merge``` cu branch-ul main. Găsești aici [Instrucțiunile pentru crearea unui branch nou și încarcarea modificărilor pe Git-ul ASMI](https://github.com/as-mi/site-asmi-nou/blob/main/Setup.md#toolbox-creare-branch-nou-și-încărcare-modificări-pe-git-ul-asmi).

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
3. Crează un nou branch prin comanda ``` git branch nume_branch```.
4. Mută-te pe noul branch prin comanda ``` git checkout nume_branch```.
5. Ar trebui să se schimbe numele noului branch în linia de comandă.
6. Incarcă noile modificari pe noul branch ```git push origin -f nume_branch```.

### *:eight_pointed_black_star: Pentru ajutor dm: @Oana @Motanu :eight_pointed_black_star:*
