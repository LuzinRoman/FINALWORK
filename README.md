Всем доброго времени суток:)))

В соответствии с заданием итоговой контрольной работы создаем репозиторий FinalWork на платформе Github.com.

Для дальнейшего планирования реализации поставленной задачи рисуем блок - схему алгоритма ее решения. Данную схему можно посмотреть перейдя по ссылке:
finalwork diagr.drawio
 

Сохраняем наши изменения с помощью команд:
***
git add .

git commit -m
***


Далее с помощью команды:
***
git push origin main
***
выгружаем данную информацию в созданный нами репозиторий FinalWork.

Используя команды:
***
git status и git log
***
проверяем статус и историю работы с файлами в программе.

Далее пишем программу на языке С#. 
Условие следующее:
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Для написания программы создаем еще одну папку TASK. 