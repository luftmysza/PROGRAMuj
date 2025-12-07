# PROGRAMuj
Inteligentna aplikacja edukacyjna wspierająca interaktywną naukę programowania przez projekty, automatyczne sprawdzanie zadań i wspieraną przez AI pomoc mentorską. 

# Platforma do nauki programowania

Inteligentna aplikacja edukacyjna wspierająca interaktywną naukę programowania przez projekty, automatyczne sprawdzanie zadań i wspieraną przez AI pomoc mentorską.

---

## Grupy docelowe

- Początkujący i osoby w zmianie kariery  
- Studenci i juniorzy  
- Pracujący developerzy  

---

## Funkcje

- Interaktywne środowisko kodowania w przeglądarce (zadania + testy automatyczne)
- Kursy: lekcje, quizy, zadania kodowe, projekty końcowe, portfolio
- System rankingowy: XP, poziomy, rankingi tygodniowe/kierunkowe
- Profil użytkownika: postępy, portfolio, certyfikaty
- Creator Studio:
  - edytor kursów
  - testy do zadań
  - preview
  - publikacja kursów
- AI:
  - czat kontekstowy w lekcji
  - generowanie wskazówek (hintów)
  - lekkie code review
- Mentor AI w lekcji:
  - tłumaczenie błędów z testów
  - podpowiadanie kolejnych kroków
  - mikropodpowiedzi
- Społeczność:
  - komentarze i Q&A pod zadaniami
  - zgłaszanie problemów

---

## Role i uprawnienia

### Uczeń
- zapis na kurs
- realizacja zadań
- udział w rankingach
- certyfikaty

### Autor
- tworzenie i publikacja kursów
- wgląd w sprzedaż i statystyki

### Moderator
- weryfikacja jakości treści
- obsługa zgłoszeń
- anty-spam

### Admin
- zarządzanie platformą
- rozliczenia
- promocje

---

## MVP — zakres i kryteria

- Baza danych:
  - InMemory
  - DBContext
  - Seed do testów
- Rejestracja i logowanie:
  - email + Google/GitHub
- Role:
  - Uczeń
  - Autor
- Katalog kursów i zapisy
- Możliwość tworzenia kursów
- Panel użytkownika:
  - śledzenie postępu
  - portfolio
  - certyfikaty
- Punkty XP, poziomy, ranking

---

## User Stories

### MUST

1. Jako użytkownik chcę przeglądać katalog kursów, aby znaleźć interesujące mnie materiały i wybrać kurs dla siebie.  
2. Jako użytkownik chcę wyświetlić szczegółowe informacje o kursie, aby ocenić jego zawartość i zdecydować, czy jest dla mnie odpowiedni.  
3. Jako użytkownik chcę założyć konto lub zalogować się na istniejące, aby móc śledzić swoje postępy w nauce i zarządzać kursami.  
4. Jako Autor chcę tworzyć i publikować nowe kursy, aby udostępniać swoją wiedzę użytkownikom platformy.  
5. Jako użytkownik chcę zapisać się na wybrany kurs, aby uzyskać dostęp do jego materiałów i rozpocząć naukę.  
8. Jako moderator chcę móc usuwać szkodliwe treści, żeby zapewnić użytkownikom jak najlepszą usługę.  
23. Jako moderator chcę mieć możliwość blokowania użytkowników naruszających zasady, żeby chronić społeczność platformy.  
24. Jako moderator chcę mieć dostęp do raportów o nadużyciach, żeby szybko reagować na problemy.  
25. Jako administrator chcę móc zarządzać rolami użytkowników (np. nadać status autora lub moderatora), żeby utrzymywać porządek i strukturę platformy.  

---

### SHOULD

6. Jako użytkownik chcę mieć możliwość rozwiązywania zadań, żeby ćwiczyć programowanie.  
10. Jako użytkownik chcę mieć podgląd profilu, żeby śledzić moje postępy i wyświetlić kursy, na które jestem zapisany.  

---

### COULD

7. Jako użytkownik chcę móc pobrać certyfikaty z profilu, żeby dodać je do swojego CV.  
9. Jako użytkownik chcę mieć dostęp do wsparcia AI, żeby pomagał mi w nauce i odpowiadał na moje pytania.  
11. Jako użytkownik chce mieć opcję logowania przez Google, LinkedIn i Microsoft, żeby przyśpieszać proces rejestracji/logowania.  
12. Jako użytkownik chcę móc oznaczać kursy jako „ulubione”, żeby łatwo do nich wracać w przyszłości.  

---

### DODATKOWE (ROZWÓJ)

13. Jako użytkownik chcę otrzymywać rekomendacje kursów na podstawie moich zainteresowań i postępów.  
14. Jako użytkownik chcę móc wystawiać oceny i opinie o kursach.  
15. Jako użytkownik chcę mieć dostęp do historii mojej aktywności.  
16. Jako użytkownik chcę otrzymywać powiadomienia o nowych lekcjach, zadaniach lub wiadomościach od autora kursu.  
17. Jako użytkownik chcę móc komunikować się z innymi uczestnikami kursu.  
18. Jako użytkownik chcę móc wznawiać kurs w miejscu, w którym przerwałem naukę.  
19. Jako Autor chcę mieć możliwość edytowania i aktualizowania opublikowanych kursów.  
20. Jako Autor chcę móc dodawać quizy i zadania w kursie.  
21. Jako Autor chcę mieć dostęp do statystyk moich kursów.  
22. Jako Autor chcę móc komunikować się z uczestnikami kursu.  

