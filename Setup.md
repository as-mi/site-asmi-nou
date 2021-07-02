# Visual Studio :fleur_de_lis:

Visual Studio (Community-it's free) 2019 (nu mai mic) ```v.16.10.2 ++``` 

:arrow_right: [Download Visual Studio 2019](https://visualstudio.microsoft.com/vs/) :arrow_left:


# ASP.NET 5
Ca sa poti rula proiectul pe PC-ul tau, asigura-te ca la instalare ai urmatoarele bifate:

### Workloads Tab
<img src="https://user-images.githubusercontent.com/61749814/124249191-4f468e00-db2c-11eb-9d81-339edd6550f2.JPG" width="1000" height="550">
<img src="https://user-images.githubusercontent.com/61749814/124249193-4fdf2480-db2c-11eb-9f46-4e78741a7b5c.JPG" width="1000" height="550">

### Individual Components Tab
<img src="https://user-images.githubusercontent.com/61749814/124249196-5077bb00-db2c-11eb-94cf-6a54ded01775.JPG" width="1000" height="550">
<img src="https://user-images.githubusercontent.com/61749814/124249199-5077bb00-db2c-11eb-89a3-d8aa4bd09c11.JPG" width="1000" height="550">

# Lucrul cu Git 
:bangbang: Fiecare contribuitor trebuie sa lucreze pe un branch separat, doar modificarile finale-intermediare sa fie introduse in branch-ul main. :bangbang:

:bangbang: De fiecare data cand te apuci sa continui la proiect, ai grija sa fie utlima versiune actulizata. :bangbang:

## Descarcare proiect (Daca nu il ai deja pe PC)
1. Instaleaza [Git pentru PC](https://git-scm.com/downloads)
2. Creaza un folder local.
3. Deschide o fereastra de Git Bash.
<img src="https://user-images.githubusercontent.com/61749814/124256376-e400ba00-db33-11eb-8966-ac61811dafe0.png" width="700" height="550">

5. Deschide proiectul in browser: [Deschide de aici](https://github.com/as-mi/site-asmi-nou)

7. Copiaza URL-ul proiectului
<img src="https://user-images.githubusercontent.com/61749814/124256380-e4995080-db33-11eb-9d57-27c18601f4f5.png" width="1000" height="500">

8. Scrie comanda:
   ```git clone https://github.com/as-mi/site-asmi-nou.git``` 
   sau 
   ``` git clone ``` + tasta Insert
<img src="https://user-images.githubusercontent.com/61749814/124256382-e531e700-db33-11eb-8ac8-55839735492e.JPG" width="850" height="600">

## Update proiect local (Daca il ai deja pe PC, dar alti contribuitori l-au mai actualizat intre timp)
1. Deschide folderul rezultat in urma clonarii ```site-asmi-nou```
2. Deschide Git Bash in el.
3. Introduce comanda ```git pull --rebase https://github.com/as-mi/site-asmi-nou.git``` sau ```git pull --rebase``` + tasta Insert (sa ai link-ul repository-ului copiat)

PS: Sa ai grija sa fii mereu pe branch-ul pe care vrei sa lucrezi. 

## Vreau sa creez un branch separat si sa incarc modificarile pe el
1. Deschide folderul rezultat in urma clonarii ```site-asmi-nou```
2. Deschide Git Bash in el.
3. Creaza un nou branch prin comanda ``` git branch nume_branch```
4. Muta-te pe noul branch prin comanda ``` git checkout nume_branch```
5. Ar trebui sa se schimbe numele noului branch in linia de comanda
6. Incarca noile modificari pe noul branch ```git push origin -f nume_branch```

:eight_pointed_black_star: PS: Pentru ajutor dm: @Oana @Motanu :eight_pointed_black_star:
