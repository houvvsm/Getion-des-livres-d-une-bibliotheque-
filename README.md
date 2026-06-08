# 📚 Système de Gestion de Bibliothèque (Academic Project)

A classic, robust desktop application developed as part of an academic evaluation (**Contrôle 2 - Programmation C# / Windows Forms**). This project demonstrates foundational object-oriented programming (OOP) principles, runtime data structures, and native GUI design using .NET Framework.

---

## 🎓 Context & Objectives
This application was built for academic assessment purposes to validate competencies in:
* **Object-Oriented Design:** Implementing clean models, properties, and custom data formatting methodologies.
* **Dynamic State Management:** Performing real-time CRUD (Create, Read, Update, Delete) operations on custom generic collections without permanent database dependencies.
* **Event-Driven Programming:** Handling component UI interaction triggers, grid selections, and input-based dataset filtering.
* **Native UI Design:** Engineering a classic, distraction-free desktop layout focused strictly on usability and native OS rendering performance.

---

## 🚀 Features

* **Dynamic Empty Startup:** Designed to start with a fresh workspace; no pre-compiled mock entries are forced into the source files. Data is entirely handled at runtime.
* **Full CRUD Operations:** Seamless capability to dynamically **Add, Modify, and Delete** books on the fly.
* **Robust Input Validation:** Built-in validation structures checking data types (e.g., ensuring IDs and Publication Years are numbers) and preventing duplication errors.
* **Contextual Primary Key Lock:** The interface dynamically locks the uniqueness constraint field (`ID Livre`) during editing cycles to secure system reference integrity.
* **Multi-Criteria Search Engine:** Filter through active table data using structured conditional routing across *Titles*, *Authors*, or *Categories*.
* **Real-time Operations Bar:** A functional bottom status strip tracking aggregate statistics dynamically, highlighting total entries, total copies on shelves, and current rentals.

---

## 🛠️ Architecture & Core Components

The architecture spans across a strict file hierarchy structure:
1.  `Livre.cs`: The core data object capsule defining properties like `IdLivre`, `Titre`, `Auteur`, `AnneePublication`, etc., along with context formatting helpers.
2.  `FormPrincipal.cs`: Contains the explicit logic event loops, conditional filters, field resets, and system state updates.
3.  `FormPrincipal.Designer.cs`: Handles layout arrangements, binding explicit text descriptions (side-labels) directly beside form inputs, and loading standard system color styling rules.
4.  `Program.cs`: The standard initialization thread responsible for booting and launching the main process window.

---

## 💻 Tech Stack & Requirements

* **Language:** C#
* **Framework:** .NET Framework (Windows Forms Classic)
* **IDE:** Visual Studio

---

## 🔧 Installation & Execution

1. Clone or download this project workspace repository into your local machine environment.
2. Open the solution file (`.sln`) inside **Visual Studio**.
3. Press **`F5`** or click the **Start/Execute** button in your IDE toolbar to build and run the executable directly.
