# Игра "Кто хочет стать миллионером?"
Лабораторная работа №1 по Практике "Базы данных и СУБД"
Кравчук Юлия (ПГНИУ, Мехмат, 3 курс, ПМИ-1-21)

# Задание
1.	Реализовать настольное приложение по мотивам телевизионного шоу «Кто хочет стать миллионером?» в соответствии с приведенными ниже правилами.
2.	Экспортировать файл с вопросами в СУБД SqlLite.
3.	Реализовать чтение вопросов из БД SqlLite.
4.	Реализовать хранение таблицы рекордов: перед новой игрой у пользователя запрашивается его имя, после окончания игры результат сохраняется в БД. На форме игры отображается список топ 10 игроков. 
Правила игры
Для победы в игре игроку необходимо верно ответить на 15 вопросов из различных областей знаний. Каждый вопрос имеет 4 варианта ответа, из которых только один является верным. Сложность вопросов постоянно возрастает. Время на раздумье над каждым вопросом у игрока не ограничено. 
Каждый из пятнадцати вопросов имеет конкретную денежную стоимость: 3 000 000, 1 500 000, 800 000, 400 000, 200 000, 100 000, 50 000, 25 000, 15 000, 10 000, 5 000, 3 000, 2 000, 1 000, 500.
Все суммы являются заменяемыми, то есть, ответив на следующий вопрос не суммируются с суммой за ответ на предыдущий. В игре существует одна несгораемая сумма - её выбирают сами участники перед началом игры. Эта сумма остаётся у игроков даже при неправильном ответе на один из последующих вопросов. 
Игроку предлагаются 5 подсказок. Участники могут использовать только четыре из пяти подсказок по ходу игры.
1.	«Помощь зала» – каждый зритель в студии голосует за правильный, на его взгляд, ответ, а игроку предоставляется статистика голосования. 
2.	«50 на 50» – компьютер убирает два неправильных ответа. 
3.	«Звонок другу» – в течение 30 секунд игрок может посоветоваться с одним из пяти друзей, заявленных заранее.
4.	«Право на ошибку» – Игрок может дать два ответа на заданный вопрос. Если первый ответ игрока оказался правильным, подсказка всё равно считается использованной. 
5.	«Замена вопроса» – игрок может заменить вопрос на другой того же уровня и той же стоимости. 
