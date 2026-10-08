# IT-MyTask: Система управления заявками в IT-аутсорсинге

Демонстрация навыков **Back-end разработки** на .NET 8, проектирования чистой архитектуры, работы с MySQL и развертывания в Linux.

**Демонстрация (Live Demo):** http://37.143.10.243 (Ubuntu 22.04 LTS)

---

## 🛠 Стек технологий и окружение
*   **Платформа:** .NET 8 SDK, ASP.NET Core (Razor Pages / MVC), C#
*   **БД и ORM:** MySQL, Entity Framework Core (Code First)
*   **Окружение:** Linux (Ubuntu VPS), Git LFS

---

## 🏗 Архитектура проекта
Приложение разделено на изолированные слои:
*   **Itmytask** — веб-интерфейс и контроллеры (слой представления).
*   **Itmytask.DAL** — слой доступа к данным и миграции EF Core.
*   **Itmytask.Domain** — бизнес-логика, модели данных и сущности.

---

## 🔥 Ключевой функционал
*   Учет, распределение и выполнение заявок в IT-компании.
*   Полноценный CRUD-интерфейс.
*   Автоматическая инициализация структуры БД и эндпоинт `/Work/GetWorks` для наполнения тестовыми данными.

---

## 🚀 Развертывание (Production)
1. Сборка оптимизированного релиза: `dotnet publish -c Release -o /var/www/itmytask`
2. Настройка фоновой службы **Systemd** (`/etc/systemd/system/itmytask.service`):
   ```ini
   [Service]
   WorkingDirectory=/var/www/itmytask
   ExecStart=/usr/bin/dotnet /var/www/itmytask/Itmytask.dll --urls=http://*:80
   Restart=always
   User=limited_user_name
   Environment=ASPNETCORE_ENVIRONMENT=Production
   ```
3. Управление службой через `systemctl start/enable itmytask.service`.

---

## 🏗 Локальный запуск
1. Клонирование: `git clone https://github.com`
2. Настройка строки подключения к MySQL в `appsettings.json`.
3. Команды для запуска:
   ```bash
   dotnet restore
   dotnet build
   dotnet run --project Itmytask
   ```
