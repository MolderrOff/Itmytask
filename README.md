"# Itmytask" 

Данная программа показывает уровень back-end разработки\
На front-end не уделялось внимания, и он был использован опосредованно лишь для демонстрации\
Веб-приложение на языке C#, описывающее взаимодейстиве сотрудников и клиентов в IT-аутсорсинговой компании\
Приложение развёрнуто на хостинге на операционной системе Linux 22.04 при помощи git\
Ссылка на сайт http://37.143.10.243\
Данное приложение всё ещё дорабатывается\
На приложение связывается с базой данных  MySQL установленном на этом же хостинге\
Ссылка  *Загрузить список всех позиций из БД, только просмотр*\
Загружает все позиции базы данных\
*Создание путём перехода на страницу /Work/GetWorks: GetWorks*\
При переходе по указанной ссылке создаются две строчки с полями, указанными ниже ссылки\
Это помогает на пустой базе данных\
Данное веб-приложение можно развернуть на любой СУБД MySQL, даже если на ней не создана\
база данных, так как в этом случае при первой связи с СУБД программа создаёт БД в случае её отсутствия.\
Ссылка *Страница/Home/NewCreate: Добавить объект в БД*\
Даёт возможность редактировать данные

Порядок сборки\
apt install -y dotnet-sdk-8.0\
dotnet restore\
dotnet build

Если развёрнуто на хостинге, то набрать\
dotnet run --urls=http://*:80
