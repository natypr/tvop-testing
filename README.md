# Тестирование веб-ориентированных приложений

Лабораторные работы по предмету.

## Задача о треугольнике (triangle-test)

* java программа
* тесты в .xlsx
* ТЗ к программе
---

## Доп. задание - Использование Selenium (selenium-addition)

* selenium тесты на с#
* подключение к mysql на java
* selenium тесты .side в IDE 

#### Задание

* автоматизировать тест с помощью Selenium IDE и Selenium WebDriver.
* Для Selenium IDE каждый пункт выполнить в отдельном тест-кейсе.
* Для Selenium RC каждый пункт выполните в отдельном тестовом методе.

`Адрес приложения` : <http://svyatoslav.biz/testlab/megaform.php>
`Литература` : <http://svyatoslav.biz/bsuir_materials/at.pdf>

#### Тесты:

1. По умолчанию поля «Фамилия», «Имя», «Отчество» пусты.
2. Поле «Дата рождения» по умолчанию содержит значение 01.01.1970.
3. Значение поля «Пол» по умолчанию не выбрано.
4. В случае, если значение списка «Страна» равно «выбрать», списки «Регион» и «Город» недоступны (disabled).
5. После изменения значения списка «Страна» список «Регион» становится доступным (enabled).
6. После отправки формы из состояния по умолчанию, вновь загруженная страница содержит исходную форму, а также следующие текстовые строки: «Не указана фамилия», «Не указано имя», «Не указано отчество», «Не указан пол», «Неверный пароль».
7. Поля «Семейное положение» и «Биография» являются полями типа textarea.
8. У всех полей формы цвет фона = #CCE6FF.
9. При заполнении всех полей корректными значениями и отправке формы, новая страница содержит сообщение «Спасибо, регистрация успешно завершена».
10. После отправки формы с неверными значениями и появления сообщения об ошибке, сообщение исчезает при изменении значения любого из следующих полей: «Фамилия», «Имя», «Отчество».

---

#### Рекомендации по выполнению

Для выполнения этого задания нужно установить связку Apache+PHP+MySQL.
Желательно НЕ использовать «костыли» в виде Денвер/XAMP/etc, а ставить
полноценный набор из независимых программ и конфигурировать их для
совместной работы.
С использованием WebDriver и phpMyAdmin автоматизировать проверку корректности создания БД со следующей структурой и данными (да, всего одна таблица):

   -- Database: `auth`
   -- Table structure for table `users`
   CREATE TABLE IF NOT EXISTS `users` (
     `u_id` int(11) NOT NULL AUTO_INCREMENT,
     `u_login` varchar(255) NOT NULL,
     `u_password` char(40) NOT NULL,
     `u_email` varchar(255) NOT NULL,
     `u_name` varchar(255) NOT NULL,
     `u_remember` char(40) NOT NULL,
     PRIMARY KEY (`u_id`)
   ) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

   -- Dumping data for table `users`


INSERT INTO `users` (`u_id`, `u_login`, `u_password`, `u_email`, `u_name`, `u_remember`) VALUES 
(1, 'user1', 'e38ad214943daad1d64c102faec29de4afe9da3d', 'user1@mail.com', 'Pupkin', ''), 
(2, 'user2', '2aa60a8ff7fcd473d321e0146afd9e26df395147', 'user2@mail.com', 'Smith', '');


CREATE DATABASE auth_un;
mysql -u root -p
mysql -u root
System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
verify element present
css=b
Спасибо, регистрация успешно завершена

verify element present
verify not present
execute script
return window.document.defaultView.getComputedStyle(window.document.getElementsByName("name_l")[0]).getPropertyValue("background-color")
