 
```markdown
# 📋 Smart Todo Tracker

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

## 🛠 Технологический стек

| Компонент | Технология |
|-----------|------------|
| **Backend** | ASP.NET Core MVC (.NET 8) |
| **ORM** | Entity Framework Core |
| **База данных** | SQL Server (LocalDB / PostgreSQL) |
| **Аутентификация** | ASP.NET Core Identity |
| **Фоновые задачи** | BackgroundService |
| **Почта** | MailKit (SMTP) |
| **Визуализация** | Chart.js |
| **Frontend** | Razor Pages + Bootstrap 5 |
| **Логирование** | ILogger |

---

## 📁 Структура проекта (монолит)

```
TodoApp/
├── Models/               // Сущности, перечисления, ViewModels
├── Data/                 // Контекст БД и репозитории
├── Services/             // EmailSender, фоновый сервис
├── Controllers/          // MVC-контроллеры
├── Views/                // Razor-представления
├── wwwroot/              // CSS, JS, библиотеки (Chart.js, Bootstrap)
├── Migrations/           // Миграции EF Core
├── Program.cs            // Настройка DI, Identity, сервисов
└── appsettings.json      // Строки подключения, настройки почты
```

---

## ⚙️ Установка и запуск

### 1. Клонирование репозитория
```bash
git clone https://github.com/yourusername/todoapp.git
cd todoapp
```

### 2. Настройка базы данных
- В `appsettings.json` укажите строку подключения к SQL Server (или PostgreSQL):
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TodoAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

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

> *Заглушка – замените на реальные изображения.*

| Главная страница (матрица) | Статистика |
|---------------------------|------------|
| ![Matrix](screenshots/matrix.png) | ![Stats](screenshots/stats.png) |

---

## 🧪 Тестирование (опционально)

Для запуска юнит-тестов (xUnit):
```bash
dotnet test
```

---

## 📝 Лицензия

Этот проект создан в учебных целях и распространяется под лицензией MIT.

---

## 🤝 Как внести вклад

Поскольку проект учебный, внешние контрибьюции не принимаются, но вы можете форкнуть репозиторий и доработать под свои задачи.

---

## ✉️ Контакты

Автор: konstant1128  
GitHub: [@yourusername](https://github.com/konstant1128)  
Email: sk292824489@gmail.com
```

---
