# Single Responsibility Principle (SRP) — Example

This repository demonstrates the **Single Responsibility Principle (SRP)**, the first of the SOLID design principles in object-oriented programming.

## 📌 What is SRP?

**Definition:**  
> A class should have only one reason to change.

A class should have **one responsibility** — it should focus on a single functionality in the system.

---

## ⚠ The Problem This Example Highlights

In the provided code:

- The `UserManager` class handles multiple responsibilities:
  - Manages users (create, update, delete)
  - Handles email service initialization
  - Handles sending emails
  - Handles logging

👉 This breaks SRP because:
- Changes in **email logic** or **email service setup** would require changes in `UserManager`.
- Changes in **logging logic** would require changes in `UserManager`.
- Changes in **user management** would also affect the same class.

👉 This increases the chance of bugs and makes the code harder to maintain, test, and extend.

---

## ✅ The Goal

- **Separate responsibilities into dedicated classes**:
  - `UserManager` → Manages user operations only
  - `EmailService` → Handles email logic and initialization
  - `Logger` → Handles logging

This ensures that each class has one reason to change.

---

## 💡 Why SRP matters

✅ Easier to maintain  
✅ Easier to extend  
✅ Easier to test  
✅ Reduces unintended side effects when modifying code  

---

## 🚀 How to use

1️⃣ Clone the repo  
2️⃣ Review the `UserManager` implementation  
3️⃣ Refactor or extend while respecting SRP  
4️⃣ Simulate failure cases (e.g. email service failure) to observe impact
