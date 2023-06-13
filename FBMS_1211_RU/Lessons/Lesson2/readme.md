Урок №2. Введение в Docker.

Шаги для начала работы с Docker:
1. Установить Docker Desktop
2. Запустить Docker Desktop
3. Возможна ошибка WSL 2 не установлен

### Что такое вообще WSL ? 

* WSL - Windows Subsystem for Linux. Это среда для запуска Linux приложений на Windows.
* WSL 2 - это вторая версия WSL, которая включает в себя виртуальную машину Linux, работающую на гипервизоре Windows.
* WSLg - Windows Subsystem for Linux GUI

[Установка Docker Desktop](https://docs.docker.com/desktop/install/windows-install/)

### Что такое Docker ?
`Docker` - это платформа для разработки, доставки и запуска приложений с помощью контейнеров. Контейнеры позволяют разработчикам упаковывать приложения со всем необходимым программным обеспечением в единообразные пакеты, которые могут быть легко перенесены в другие системы.

Вопросы, которые сразу возникают:
- Для чего нужен Docker ?
- Что такое контейнер ?
- Почему именно Docker ?
- Какие проблемы решает Docker ?
- Как так получается что Docker и для разработки и для доставки и для запуска ?
- Что за единообразные пакеты ?

Ответы на эти вопросы: 

### Для чего нужен Docker ?
Пример: 
<br>
У меня есть любое приложение. Предположим что это монолитное ASP.NET MVC  

Какие у нас есть варианты для его загрузки на сервер ? 
- Скопировать все файлы на сервер. Будет ли это работать ? Нет. Потому что на сервере нет IIS, нет .NET Core, нет SQL Server, нет других зависимостей.
- Даже если, на нашем сервере уже есть все необходимые зависимости, типо .NET Core, SQL Server и т.д. это не дает нам гаранитий на будущие обновления.
* * Тут имеется ввиду зависимости самого проекта, а не решения
- FTP сервер, который будет синхронизировать наши файлы с сервером. Но это не решает проблему с зависимостями.
- IIS Web Deploy. Но это не поддерживает Linux сервера, а так же не решает проблему с зависимостями.
- Использовать Azure Web Services, с помощью Github Actinos.
* * Это хорошее решение, но оно дорогое. И не решает проблему с зависимостями.


### Как в этом случае поможет Docker ?

Самое первое что нужно знать. ***Docker - это виртуализация на уровне ОС***.

У вас есть `Images`. Образ какой-то OS.

С каждого  `Image` можно создать `Container`
#### Аналогия: Image - это класс, а Container - это экземпляр класса.

То есть созданная виртуальная машина, это `Container` созданный из `Image`.

Все нужные Image, можно скачать автоматически из `Docker Hub`.


`Docker Hub` - это репозиторий образов. Так же как и `Github`, но для образов.


### Почему именно Docker ?

Похожие технологии уже были созданы, в то время как Docker был создан в 2013 году.

Docker принадлежит компании Docker Inc. Которая была основана в 2010 году

### История контейнеров 
* 1979 - chroot
* 2000 - FreeBSD Jails
* 2001 - Linux VServer
* 2004 - Solaris Containers
* 2005 - OpenVZ
* 2006 - Process Containers
* 2008 - LXC
* 2011 - Docker
* 2014 - Mesos
* 2014 - CoreOS
* 2015 - Mesosphere DC/OS
* 2015 - Amazon ECS
* 2016 - Docker Datacenter
* 2016 - Rancher
* 2016 - Nomad
* 2017 - CRI-O
* 2017 - Containerd
* 2017 - CRI Containerd
* 2017 - Kata Containers
* 2017 - Fargate
* 2018 - Firecracker
* 2018 - Knative

Преимущества Docker над остальными:
* Docker - это открытый исходный код
* Docker - это легковесный
* Docker - это переносимый
* Docker - это безопасный
* Docker - это модульный


### Какие проблемы решает Docker ?
* Главная проблема - это зависимости.
* Это общение программ друг с другом. Те же самые микросервисы.
* Проблема с запуском и восстановлением приложения.
* Это разные версии ОС.
* Проблему с доставкой приложения на сервер.


### Как так получается что Docker и для разработки и для доставки и для запуска ?
 
На этапе разработке можно делать build и запускать проект напрямую в Docker. Это называется `Docker Compose`.
Для доставки приложения на сервер, можно использовать `Docker Hub` или `Azure Container Registry`.
Для запуска приложения на сервере, можно использовать `Docker Compose` или `Kubernetes`.

### Что за единообразные пакеты ?

Все приложения, которые запускаются в Docker, это контейнеры. Контейнеры это единообразные пакеты.


Hello from Copilot

