# 📋 Smart Todo Tracker

[![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Status](https://img.shields.io/badge/Status-In%20Development-orange.svg)]()

**Умный персональный трекер задач** – веб-приложение для управления личными задачами с интеллектуальной сортировкой (матрица Эйзенхауэра), аналитикой продуктивности и автоматическими email‑напоминаниями.

> 🎓 Учебный проект по программной инженерии.

---

## 🚀 Основные возможности

- 🔐 **Аутентификация** – регистрация и вход по email/паролю (ASP.NET Core Identity).
- ✅ **Управление задачами** – создание, редактирование, удаление, отметка о выполнении.
- 📊 **Матрица Эйзенхауэра** – автоматическая группировка задач по 4 квадрантам на главной странице.
- 📈 **Аналитика** – график выполненных задач за 7 дней и метрики (всего, просрочено, среднее время выполнения).
- ⏰ **Умные напоминания** – фоновый сервис отправляет email за 24 часа до дедлайна.
- 🎨 **Адаптивный интерфейс** – Bootstrap 5, кросс-браузерность.

---

## 📋 Требования

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) или выше
- Git (для клонирования репозитория)
- Любой современный браузер (Chrome, Firefox, Edge)

---

## 🚧 Текущий статус

Проект находится в активной разработке.

**Реализовано:**
- ✅ Аутентификация (регистрация/вход)
- ✅ CRUD для задач (создание, редактирование, удаление, отметка выполнения)
- ✅ Репозиторий с изоляцией данных по пользователям
- ✅ Валидация форм на клиенте и сервере

**В разработке:**
- 🔄 Матрица Эйзенхауэра
- 🔄 Статистика и графики
- 🔄 Email-напоминания

---

## 🛠 Технологический стек

| Компонент | Технология |
|-----------|------------|
| **Backend** | ASP.NET Core MVC (.NET 8) |
| **ORM** | Entity Framework Core |
| **База данных** | SQLite (файловая БД) |
| **Аутентификация** | ASP.NET Core Identity |
| **Фоновые задачи** | BackgroundService |
| **Почта** | MailKit (SMTP) |
| **Визуализация** | Chart.js |
| **Frontend** | Razor Views + Bootstrap 5 |
| **Логирование** | ILogger |

---

## 📁 Структура проекта

```
TodoApp/
├── Models/
│   ├── Entities/           # TaskItem, ApplicationUser
│   ├── Enums/              # Priority, Urgency
│   └── ViewModels/         # TaskCreateViewModel, TaskEditViewModel
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Repositories/       # ITaskRepository, TaskRepository
├── Controllers/
│   ├── HomeController.cs
│   └── TasksController.cs
├── Views/
│   ├── Home/
│   ├── Tasks/              # Index, Create, Edit
│   └── Shared/
├── wwwroot/                # CSS, JS, Bootstrap
├── Migrations/             # Миграции EF Core
├── Program.cs              # DI, Identity, сервисы
├── appsettings.json        # Строка подключения SQLite
└── todoapp.db              # Файл базы данных (создается автоматически)
```

---

## ⚙️ Установка и запуск

### 1. Клонирование репозитория
```bash
git clone https://github.com/yourusername/todoapp.git
cd todoapp
```

### 2. Настройка базы данных
База данных SQLite создается автоматически при первом запуске. Строка подключения уже настроена в `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=todoapp.db"
}
```
Никаких дополнительных действий не требуется — база создастся автоматически.

### 3. Применение миграций
```bash
dotnet ef database update
```

### 4. Настройка email-уведомлений (опционально)
Добавьте в `appsettings.json`:
```json
"EmailSettings": {
  "SmtpServer": "smtp.gmail.com",
  "Port": 587,
  "SenderEmail": "your-email@gmail.com",
  "SenderPassword": "your-app-password"
}
```
> Для теста можно использовать [Mailtrap](https://mailtrap.io/).

### 5. Запуск приложения
```bash
dotnet run
```
Откройте браузер по адресу `https://localhost:5001` (или указанному в консоли).

---

## 📸 Скриншоты

> Скриншоты будут добавлены по мере реализации интерфейса.

---

## 🧪 Тестирование (планируется)

Юнит-тесты (xUnit) будут добавлены на финальном этапе разработки.

---

## 📝 Лицензия

Этот проект создан в учебных целях и распространяется под лицензией MIT.

---

## 🤝 Как внести вклад

Поскольку проект учебный, внешние контрибьюции не принимаются, но вы можете форкнуть репозиторий и доработать под свои задачи.

---

## 📞 Контакты

Если у вас есть вопросы по проекту, создайте Issue в этом репозитории.

---

## ✉️ Контакты

Автор: konstant1128  
GitHub: [@konstant1128 ](https://github.com/konstant1128)  
Email: sk292824489@gmail.com