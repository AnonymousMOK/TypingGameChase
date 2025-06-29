
# 🐟 TypingGameChase 🦈
A fun and interactive typing speed game built using **C# and Windows Forms**, where you race against a shark by typing sentences correctly and quickly. If you’re too slow or make mistakes, the shark catches you!

## 📸 Screenshots


![Main Menu](Screenshots/mainmenu.png)
![Game Play](Screenshots/gameplay.png)
![Leaderboard](Screenshots/leaderboard.png)

---

## 🎮 Game Concept

You play as a **fish** being chased by a **shark**. The only way to survive is to **type quickly and accurately**! Each correct keystroke pushes your fish forward. Mistakes and slow typing give the shark a chance to catch up.

---

## 👥 Group Members

- **Muhammad Omer Khan** *(Team Lead & Developer)*  

---

## 📦 Project Structure

```
TypingGameChase/
│
├── GameForm.cs               # Main game logic and event handling
├── Form1.cs                  # Main menu form
├── LeaderboardForm.cs        # Displays top scores
├── Fish.cs / Shark.cs        # Game characters
├── Player.cs                 # Player WPM tracking
├── GameEngine.cs             # Central game logic manager
├── SentenceManager.cs        # Provides random typing sentences
├── Resources/Audio/          # Underwater and swimming sound effects
├── Resources/Images/         # Fish and Shark images
└── leaderboard.txt           # Score saving (local file-based)
```

---

## 🛠️ Tools Used

- **.NET Framework / .NET 8 (Windows Forms)**
- **C# (Object-Oriented Programming)**
- **Visual Studio 2022**
- **GDI+** for UI rendering and image scaling
- **System.Media** for playing sound effects

---

## ✨ Features

- ⌨️ **Real-time typing detection**  
- 🐟 **Dynamic Fish movement based on typing speed**  
- 🦈 **Shark chase mechanics that respond to user performance**  
- 📊 **Leaderboard system** with local score tracking  
- 🎵 **Background and swimming sound effects**  
- 🖥️ **Full-screen adaptive layout**  
- 💾 **Score persistence using .txt file**

---

## 🚀 Getting Started

### Prerequisites

- .NET Desktop Runtime (.NET 6 or 8)
- Visual Studio with WinForms support

### How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/TypingGameChase.git
   ```

2. Open `TypingGameChase.sln` in Visual Studio.

3. Build and Run the project.

---

## 📁 Notes

- All **audio files** must be placed inside:
  ```
  /Resources/Audio/
    - underwater sound.wav
    - swimming sound.wav
  ```
- Ensure that **image assets** (`fish.png`, `shark.png`) are in:
  ```
  /Resources/Images/
  ```

---

## 🧠 Learning Outcomes

- Hands-on understanding of **Windows Forms**
- Mastery of **Object-Oriented Programming (OOP)**
- Event-driven programming and UI responsiveness
- Working with **media assets and timers** in C#

---

## 🏁 Future Improvements

- Add **difficulty levels** (Beginner, Intermediate, Advanced)
- Implement **high score saving with database**
- Enhance **UI animations** and visual effects
- Add **multiplayer or network-based typing challenges**

---

## 📃 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

---

## 💬 Acknowledgements

- Special thanks to our **teachers and reviewers** for their guidance.
- Inspired by the idea of making **typing practice fun**.

---

📬 For questions, feedback, or suggestions:  
**Email:** muhammadomerkhan2005@outlook.com  
**GitHub:** [github.com/AnonymousMOK](https://github.com/AnonymousMOK)
