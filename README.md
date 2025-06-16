# Single Responsibility Principle (SRP) — Example

This repository demonstrates the **Single Responsibility Principle (SRP)**, the first of the SOLID design principles in object-oriented programming.

## 📌 What is SRP?

**Definition:**  
> A class should have only one reason to change.

In other words, a class should have **one responsibility** — it should focus on a single functionality in the system.

---

## ⚠ The Problem This Example Highlights

In the provided code:
- The `UserManager` class handles multiple responsibilities:
  - Manages users (create, update, delete)
  - Handles database connection
  - Handles email sending
  - Handles logging

👉 This breaks SRP because changes in database logic, email logic, or logging will require changes in `UserManager`, increasing the chance of bugs and making maintenance harder.

---

## ✅ The Goal

- **Separate responsibilities into dedicated classes.**
- Each class should have a single responsibility (e.g., managing users, handling database connections, sending emails).

---

## 💡 Why SRP matters

✅ Easier to maintain  
✅ Easier to extend  
✅ Easier to test  
✅ Reduces the risk of unintended side effects

---

## 🚀 How to use

1️⃣ Clone the repo  
2️⃣ Open the code in your IDE  
3️⃣ Review how the responsibilities are split  
4️⃣ Run and modify to see the impact of clean separation


