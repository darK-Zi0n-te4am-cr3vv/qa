Самое быстрое шифрование/дешифрование
-------------------------------------
 - **Rijndael**
 - MARS
 - Serpent
 - **RC6**
 - Twofish

Невозможность получения сервиса законным пользователем называется
-----------------------------------------------------------------
 - **DoS-атакой**
 - Replay-aтакой
 - атакой «man-in-the-middle»

Криптоанализ – это процесс, при котором
---------------------------------------
 - **зная зашифрованное сообщение, пытаются узнать незашифрованное сообщение**
 - **зная одну или несколько пар (незашифрованное сообщение, зашифрованное сообщение), пытаются узнать ключ**
 - изменяют передаваемое зашифрованное сообщение

Под replay-атакой в данном контексте понимают:
----------------------------------------------
 - возможность взлома ключа сессии
 - **возможность использования старого ключа сессии**
 - возможность взлома KDC

Алгоритм ГОСТ 28147
-------------------
 - имеет переменную длину ключа
 - **основан на сети Фейcтеля**
 - разбивает блок на фиксированные 16-битные подблоки

В протоколе Деннинга защита от replay-атак выполняется с помощью
----------------------------------------------------------------
 - **отметки времени**
 - последовательного номера
 - nonce

В алгоритмах симметричного шифрования используются только следующие операции:
-----------------------------------------------------------------------------
 - операции перестановки и сдвига
 - S-box и побитовое исключающее или (XOR)
 - **любые из перечисленных выше операций, а также многие другие**

Длина блока в алгоритме Rijndael может быть
-------------------------------------------
 - **128 бит**
 - **192 бита**
 - **256 бит**

При односторонней аутентификации
--------------------------------
 - наличие KDC обязательно
 - **наличие KDC не обязательно**

Выберите правильное утверждение:
--------------------------------
 - **подпись должна быть битовым образцом, который зависит от подписываемого сообщения**
 - **подпись должна использовать некоторую уникальную информацию отправителя для предотвращения подделки или отказа**
 - подпись должна обеспечивать невозможность просмотра сообщения

Аутентификация – это
--------------------
 - невозможность несанкционированного доступа к данным
 - **подтверждение того, что информация получена из законного источника законным получателем**
 - невозможность несанкционированного просмотра и модификации информации

Для передачи коротких сообщений лучше всего соответствуют режимы
----------------------------------------------------------------
 - **ECB**
 - CBC
 - CFB
 - OFB

Мастер-ключ используется для
----------------------------
 - **шифрования ключа сессии**
 - шифрования прикладных данных
 - шифрования как ключа сессии, так и прикладных данных

Атака «man in the middle» является
----------------------------------
 - пассивной
 - **активной**
 - может быть как активной, так и пассивной

В алгоритме RC6 используются следующие операции
-----------------------------------------------
 - **сложение целых по модулю 232**
 - **вычитание целых по модулю 232**
 - **умножение целых по модулю 232**

Каждый блок сообщения в хэш-функции MD5 обрабатывается
------------------------------------------------------
 - 4 раза
 - 16 раз
 - **64 раза**

Модификация передаваемого сообщения называется
----------------------------------------------
 - DoS-атакой
 - Replay-aтакой
 - **атакой «man-in-the-middle»**

На основе сети Фейcтеля построены следующие алгоритмы
-----------------------------------------------------
 - Rijndael
 - **MARS**
 - Serpent
 - **RC6**
 - **Twofish**

Максимальная длина ключа в алгоритме Blowfish
---------------------------------------------
 - 512 бит
 - 128 бит
 - 256 бит
 - **448 бит**

Что из перечисленного относится к механизмам безопасности ?
-----------------------------------------------------------
 - **хэш-функции**
 - целостность сообщения
 - **алгоритмы симметричного шифрования**
 - невозможность отказа от полученного сообщения

Сервис, который обеспечивает невозможность несанкционированного просмотра данных, называется
--------------------------------------------------------------------------------------------
 - аутентификацией
 - целостностью
 - **конфиденциальностью**

Криптографическая система называется симметричной, потому что
-------------------------------------------------------------
 - шифруемый блок разбивается на подблоки одинаковой длины
 - **для шифрования и дешифрования используются одинаковые или легко выводимые один из другого ключи**
 - алгоритм использует циклически повторяющиеся операции, называемые раундами

Зависимость между ключами шифрования и дешифрования в алгоритмах симметричного шифрования должна быть следующей:
----------------------------------------------------------------------------------------------------------------
 - **ключи шифрования и дешифрования должны в точности совпадать**
 - **ключ дешифрования должен легко получаться из ключа шифрования**
 - между ключами шифрования и дешифрования не должно быть никакой зависимости

Выберите правильное утверждение:
--------------------------------
 - **мастер-ключ должен быть более защищенным, чем ключ сессии+++++**
 - ключ сессии должен быть более защищенным, чем мастер-ключ
 - мастер-ключ и ключ сессии должны иметь одинаковую степень защиты

Какому полиному соответствует шестнадцатеричное число F8
--------------------------------------------------------
 - x6 + x5 + x4 + 1
 - x7 + x6 + x5 + x4 + x3 + x2 + x + 1
 - **x7 + x6 + x5 + x4 + x3**

Алгоритм симметричного шифрования называется блочным, если
----------------------------------------------------------
 - алгоритм основан на сети Фейстеля
 - **для шифрования исходный текст разбивается на блоки фиксированной длины**
 - в алгоритме используются S-box

Длина ключа в алгоритме ГОСТ 28147
----------------------------------
 - 56 бит
 - 128 бит
 - **256 бит**
 - 448 бит

Подпись, создаваемая RSA, является
----------------------------------
 - **детерминированной**
 - рандомизированной

Под replay-атакой понимается:
-----------------------------
 - модификация передаваемого сообщения
 - **повторное использование переданного ранее сообщения**
 - невозможность получения сервиса законным пользователем

С точки зрения теории вероятностей «парадокс дня рождения» формулируется следующим образом
------------------------------------------------------------------------------------------
 - сколько значений Y1, ..., Yk необходимо перебрать, чтобы для конкретного значения X вероятность того, что хотя бы для одного Yi выполнялось равенство H (X) = H (Y), была бы равна 1
 - сколько значений Y1, ..., Yk необходимо перебрать, чтобы для конкретного значения X вероятность того, что бы для всех Yi выполнялось равенство H (X) = H (Y), была бы больше 0,5

Целостность – это
-----------------
 - невозможность несанкционированного просмотра информации
 - **невозможность несанкционированного изменения информации**
 - невозможность несанкционированного доступа к информации

Для увеличения стойкости алгоритма количество раундов следует
-------------------------------------------------------------
 - уменьшить
 - **увеличить**
 - удвоить

В качестве AES было решено выбрать
----------------------------------
 - **один алгоритм**
 - два алгоритма
 - пять алгоритмов

Алгоритм Twofish характеризуется следующими свойствами
------------------------------------------------------
 - **использует преобразование псевдо-Адамара**
 - **основан на сети Фейcтеля c 16 раундами**
 - **использует S-boxes**

Сервис, который гарантирует, что информация получена из законного источника и получателем является тот, кто нужно, называется
-----------------------------------------------------------------------------------------------------------------------------
 - **аутентификацией**
 - целостностью
 - конфиденциальностью

Причина использования двух ключей в тройном DES состоит в том, что
------------------------------------------------------------------
 - в этом случае отсутствует атака «встреча посередине»
 - стойкость алгоритма не повышается при использовании трех ключей вместо двух
 - **при использовании трех ключей общая длина ключа равна 168 битам, что может потребовать существенно больших вычислений при его распределении**

Под билетом понимается
----------------------
 - случайное число
 - **блок данных, зашифрованный секретным ключом, разделяемым каким-либо из участников и KDC**
 - отметка времени

Хэш-функция должна обладать следующими свойствами:
--------------------------------------------------
 - **для любого данного значения хэш-кода h вычислительно невозможно найти M такое, что Н (M) = h**
 - хэш-функция Н должна применяться к блоку данных фиксированной длины
 - **хэш-функция Н создает выход фиксированной длины**

Выберите правильное утверждение
-------------------------------
 - **должно быть вычислительно невозможно подделать цифровую подпись как созданием нового сообщения для существующей цифровой подписи, так и созданием ложной цифровой подписи для некоторого сообщения**
 - **цифровая подпись должна быть достаточно компактной и не занимать  много памяти**
 - подпись обязательно должна быть рандомизированной

Повторное использование переданного ранее сообщения называется
--------------------------------------------------------------
 - DoS-атакой
 - **Replay-aтакой**
 - атакой «man-in-the-middle»

Выберите правильное высказывание
--------------------------------
 - каждая элементарная функция в алгоритме MD5 получает одно 32-битное слово на входе и на выходе создает три 32-битных слова
 - каждая элементарная функция в алгоритме MD5 получает три 32-битных слова на входе и на выходе создает три 32-битных слова
 - **каждая элементарная функция в алгоритме MD5 получает три 32-битных слова на входе и на выходе создает одно 32-битное слово**

Алгоритм IDEA
-------------
 - имеет переменную длину ключа
 - основан на сети Фейштеля
 - **разбивает блок на фиксированные 16-битные подблоки**

Выберите правильное утверждение:
--------------------------------
 - **подпись должна быть битовым образцом, который зависит от подписываемого сообщения**
 - **подпись должна использовать некоторую уникальную информацию отправителя для предотвращения подделки или отказа**
 - подпись должна обеспечивать невозможность просмотра сообщения

Длина ключа алгоритма AES должна быть не меньше
-----------------------------------------------
 - 56 бит
 - **128 бит**
 - 256 бит

Под DoS-атакой понимается:
--------------------------
 - модификация передаваемого сообщения
 - повторное использование переданного ранее сообщения
 - **невозможность получения сервиса законным пользователем**

Выберите правильное утверждение:
--------------------------------
 - **в основе алгоритма DES лежит сеть Фейштеля**
 - **в алгоритме DES используются S-boxes**
 - в алгоритме DES используется умножение по модулю 216 + 1

Протокол аутентификации с использованием симметричного шифрования и билета для защиты от replay-атак использует
---------------------------------------------------------------------------------------------------------------
 - **nonce**
 - **отметку времени**
 - открытый ключ KDC

Nonce – это
-----------
 - последовательный номер данной сессии
 - **случайное число, созданное специально для данной сессии**
 - отметка времени

При односторонней аутентификации осуществляется аутентификация
--------------------------------------------------------------
 - **отправителя**
 - получателя
 - KDC

В протоколе Нидхэма-Шредера KDC выполняет:
------------------------------------------
 - **аутентификацию участников**
 - **распределение ключа сессии**
 - распределение открытых ключей участников

Выберите правильное утверждение:
--------------------------------
 - **в протоколах аутентификации с использованием шифрования с открытым ключом участники должны  знать открытый ключ AS или KDC**
 - в протоколах аутентификации с использованием шифрования с открытым ключом участники должны  знать открытые ключи друг друга
 - в протоколах аутентификации с использованием шифрования с открытым ключом участники должны  знать как открытый ключ AS или KDC, так и открытые ключи друг друга

Выберите правильное утверждение:
--------------------------------
 - в любом протоколе аутентификации ключ сессии всегда создается третьей доверенной стороной
 - в любом протоколе аутентификации ключ сессии всегда создается участником А
 - **существуют различные протоколы, в одних ключ сессии создается KDC, в других - одним из участников А или В**

При односторонней аутентификации ключ сессии может шифроваться
--------------------------------------------------------------
 - **открытым ключом получателя**
 - закрытым ключом отправителя
 - **мастер-ключом для симметричного шифрования, разделяемым отправителем и KDC**

Подпись с использованием эллиптических кривых имеет
---------------------------------------------------
 - один компонент
 - **два компонента**
 - три компонента

Выберите правильное высказывание
--------------------------------
 - подпись с использованием эллиптических кривых является детерминированной
 - **подпись с использованием эллиптических кривых является рандомизированной**
 - уравнения на эллиптических кривых нельзя использовать для создания цифровых подписей

При использовании криптографии на эллиптических кривых в качестве аналога алгоритма Диффи-Хеллмана в уравнении PA = nA×G точка G называется
-------------------------------------------------------------------------------------------------------------------------------------------
 - **генерирующей точкой**
 - нулевым элементом
 - открытым ключом

Нулевым элементом эллиптической кривой считается точка О, которая
-----------------------------------------------------------------
 - имеет координаты (0, 0)
 - **является бесконечно удаленной точкой, в которой сходятся все вертикальные прямые**
 - имеет координаты (0, 1) или (1, 0)

Криптография с использованием эллиптических кривых дает преимущества по сравнению с другими алгоритмами, потому что
-------------------------------------------------------------------------------------------------------------------
 - принципиально не может быть взломана
 - **обеспечивает эквивалентную защиту при меньшей длине ключа**
 - проще в реализации

Элементами эллиптической кривой являются пары неотрицательных целых чисел, которые меньше простого числа р и удовлетворяют частному виду эллиптической кривой:
--------------------------------------------------------------------------------------------------------------------------------------------------------------
 - y ≡ x2 + ax + b (mod p)
 - **y2 ≡ x3 + ax + b (mod p)**
 - y2 ≡ x3 + ax2 + b (mod p)

При использовании криптографии на эллиптических кривых в качестве аналога алгоритма Диффи-Хеллмана в уравнении PA = nA×G точка PA называется
--------------------------------------------------------------------------------------------------------------------------------------------
 - генерирующей точкой
 - нулевым элементом
 - **открытым ключом**

Длина блоков, на которые делится сообщение в хэш-функции SHA-1, равна
---------------------------------------------------------------------
 - 160 бит
 - **512 бит**
 - 1024 бит

Длину блока 256 бит имеют следующие хэш-функции
-----------------------------------------------
 - **ГОСТ 3411**
 - SHA-1
 - SHA-256
 - SHA-384
 - SHA-512

Выберите правильное высказывание
--------------------------------
 - **криптография с использованием эллиптических кривых может использоваться для шифрования сообщения**
 - криптография с использованием эллиптических кривых не может использоваться для шифрования сообщения

При использовании криптографии на эллиптических кривых в качестве аналога алгоритма Диффи-Хеллмана в уравнении PA = nA×G
------------------------------------------------------------------------------------------------------------------------
 - **открытым ключом участника А является PA, закрытым ключом участника А является nA**
 - открытым ключом участника А является nA, закрытым ключом участника А является PA
 - открытым ключом участника А является PA, закрытым ключом участника А является G

Уравнение эллиптической кривой в общем случае имеет вид:
--------------------------------------------------------
 - **y2 + axy + by = x3 + cx2 + dx + e**
 - y = ax2+ c
 - y2 = ax2 + bx + c

Выберите правильное утверждение:
--------------------------------
 - в криптографии с использованием эллиптических кривых все значения вычисляются по модулю n, где n – произведение двух простых чисел
 - **в криптографии с использованием эллиптических кривых все значения вычисляются по модулю простого числа р**
 - в криптографии с использованием эллиптических кривых все значения вычисляются по модулю произвольного числа р

Шифрование/дешифрование с использованием эллиптических кривых выполняется следующим образом:
--------------------------------------------------------------------------------------------
 - **участник А выбирает случайное целое положительное число k и вычисляет зашифрованное сообщение Cm, являющееся точкой на эллиптической кривой Cm = {k ×G, Pm + k ×PB}**
 - участник А выбирает случайное целое положительное число k и вычисляет зашифрованное сообщение Cm, являющееся точкой на эллиптической кривой Cm = { Pm + k ×PB}

Задача, которую должен решить  атакующий, формулируется следующим образом:
--------------------------------------------------------------------------
 - **даны точки P и Q на эллиптической кривой Ep (a,b). Необходимо найти коэффициент k &lt; p такой, что P = k×Q**
 - дана точка Q на эллиптической кривой Ep (a,b) и целое число k. Необходимо найти такую точку Р на данной кривой, чтобы P = k×Q
 - дана точка Р на эллиптической кривой Ep (a,b) и целое число k. Необходимо найти такую точку Q на данной кривой, чтобы P = k×Q

Подпись называется рандомизированной, если
------------------------------------------
 - для разных сообщений с использованием одного и того же закрытого ключа при каждом подписывании создаются разные подписи
 - **для одного и того же сообщения с использованием одного и того же закрытого ключа при каждом подписывании создаются разные подписи**
 - для одного и того же сообщения с использованием разных закрытых ключей при каждом подписывании создаются разные подписи

Подпись, создаваемая ГОСТ 3410, является
----------------------------------------
 - детерминированной
 - **рандомизированной**

Из двух компонент (r, s) состоит подпись, полученная с использованием алгоритма
-------------------------------------------------------------------------------
 - RSA
 - **DSS**
 - **ГОСТ 3410**

Укажите, какая подпись является рандомизированной
-------------------------------------------------
 - RSA
 - **DSS**
 - **ГОСТ 3410**

Подпись, создаваемая DSS, является
----------------------------------
 - детерминированной
 - **рандомизированной**

Выберите правильные утверждения
-------------------------------
 - **должно быть относительно легко создавать цифровую подпись**
 - должно быть относительно трудно создавать цифровую подпись
 - **должно быть относительно легко проверять цифровую подпись**

Подпись называется детерминированной, если
------------------------------------------
 - для одного и того же сообщения с использованием разных закрытых ключей при каждом подписывании создается одна и та же подпись
 - для разных сообщений с использованием одного и того закрытого ключа при каждом подписывании создается одна и та же подпись
 - **для одного и того же сообщения с использованием одного и того же закрытого ключа при каждом подписывании создается одна и та же подпись**

Выберите правильное утверждение
-------------------------------
 - **подпись должна быть проверяема третьей стороной**
 - подпись не должна быть проверяема третьей стороной
 - подпись должна быть проверяема только получившей ее стороной

Укажите, какая подпись является детерминированной
-------------------------------------------------
 - **RSA**
 - DSS
 - ГОСТ 3410

В DSS используется следующая хэш-функция
----------------------------------------
 - MD5
 - **SHA-1**
 - SHA-2

В стандарте ГОСТ 3410 используется следующая хэш-функция
--------------------------------------------------------
 - MD5
 - SHA-1
 - **ГОСТ 3411**

Дополнительными параметрами хэш-функции ГОСТ 3411 являются
----------------------------------------------------------
 - **стартовый вектор хэширования**
 - ключи для алгоритма симметричного шифрования ГОСТ 28147
 - начальное значение хэш-кода

Длина блоков, на которые делится сообщение в хэш-функции SHA-512, равна
-----------------------------------------------------------------------
 - 512 бит
 - **1024 бит**
 - 1024 байт

Алгоритм НМАС позволяет
-----------------------
 - **использовать без модификаций уже имеющиеся хэш-функции**
 - **осуществлять замену встроенной хэш-функции на более быстрые или более стойкие**
 - выполнять сжатие сообщения

Длина хэш-кода, создаваемого хэш-функцией SHA-1, равна
------------------------------------------------------
 - 128 бит
 - **160 бит**
 - 512 бит

При разработке алгоритма НМАС преследовались следующие цели:
------------------------------------------------------------
 - **возможность использовать без модификаций уже имеющиеся хэш-функции**
 - возможность усилить алгоритм по сравнению с используемой им хэш-функцией
 - **возможность легкой замены встроенных хэш-функций на более быстрые или более стойкие**

Длина хэш-кода хэш-функции ГОСТ 3411 равна
------------------------------------------
 - 128 бит
 - 160 бит
 - **256 бит**

В хэш-функции ГОСТ 3411 при вычислении промежуточного значения хэш-кода используется алгоритм симметричного шифрования ГОСТ 28147
---------------------------------------------------------------------------------------------------------------------------------
 - ключи для этого алгоритма являются дополнительным параметром хэш-функции ГОСТ 3411
 - **ключи для этого алгоритма вычисляются по определенным формулам из хэшируемого сообщения**
 - ключи для этого алгоритма вычисляются из стартового вектора хэширования

Длина блоков, на которые делится сообщение в хэш-функции ГОСТ 3411, равна
-------------------------------------------------------------------------
 - **256 бит**
 - 512 бит
 - 1024 бит

Код аутентификации сообщения (МАС) может создаваться
----------------------------------------------------
 - только с использованием алгоритмов симметричного шифрования
 - только с использованием хэш-функций
 - **как с использованием алгоритмов симметричного шифрования, так и с использованием хэш-функций**

Сильная хэш-функция отличается от слабой наличием следующего свойства:
----------------------------------------------------------------------
 - у сильной хэш-функции для любого данного значения хэш-кода h вычислительно невозможно найти M такое, что Н (M) = h
 - **у сильной хэш-функции вычислительно невозможно найти произвольную пару (х, y) такую, что H (y) = H (x)**
 - у сильной хэш-функции для любого данного х вычислительно невозможно найти y ≠ x, что H (y) = H (x)

Требование односторонности хэш-функции состоит в следующем
----------------------------------------------------------
 - хэш-код может быть вычислен для сообщения любой длины
 - **легко создать хэш-код по данному сообщению, но вычислительно невозможно восстановить сообщение по данному хэш-коду**
 - вычислительно невозможно найти два сообщения, имеющих одинаковый хэш-код

Выходом хэш-функции является
----------------------------
 - сообщение той же длины, что и входное сообщение
 - **сообщение фиксированной длины**
 - сообщение меньшей длины

Длина блоков, на которые делится сообщение, в хэш-функции MD5 равна
-------------------------------------------------------------------
 - 128 бит
 - **512 бит**
 - 1024 бит

«Парадокс дня рождения» состоит в том, что
------------------------------------------
 - **для того, чтобы вероятность совпадения дней рождения у двух человек была больше 0.5, в группе должно быть всего 23 человека**
 - для того, чтобы вероятность совпадения дней рождения у двух человек была больше 0.5, в группе должно быть всего 32 человека
 - для того, чтобы вероятность совпадения дней рождения у двух человек была равна 1, в группе должно быть всего 23 человека

Хэш-функция должна обладать следующими свойствами:
--------------------------------------------------
 - **Н (М) относительно легко (за полиномиальное время) вычисляется для любого значения М**
 - **для любого данного х вычислительно невозможно найти y ≠ x, что H (y) = H (x)**
 - для любого данного х вычислительно невозможно найти H (х)

Хэш-функции предназначены для
-----------------------------
 - сжатия сообщения
 - **получения «отпечатков пальцев» сообщения**
 - шифрования сообщения

Первым шагом в хэш-функции MD5 выполняется добавление битов, цель которого
--------------------------------------------------------------------------
 - скрыть истинную длину сообщения
 - **сделать сообщение кратным 512 битам**
 - добавить случайные биты, усложняющие восстановление сообщения

Хэш-функция должна обладать следующими свойствами:
--------------------------------------------------
 - **хэш-функция должна применяться к блоку данных любой длины**
 - хэш-функция должна создавать выход произвольной длины
 - **для любого данного значения хэш-кода h вычислительно невозможно найти M такое, что Н (M) = h**

Побитовый XOR блоков нельзя считать криптографической хэш-функцией, потому что
------------------------------------------------------------------------------
 - **противник может легко подобрать другое сообщение, имеющее тот же хэш-код**
 - побитовый XOR плохо защищает от случайного сбоя
 - побитовый XOR требует сложных вычислений

Длина хэш-кода, создаваемого хэш-функцией MD5, равна
----------------------------------------------------
 - **128 бит**
 - 160 бит
 - 512 бит

Алгоритм RSA может использоваться для
-------------------------------------
 - **подписывания**
 - **шифрования**
 - **обмена общим секретом**

Для шифрования сообщения следует использовать
---------------------------------------------
 - свой открытый ключ
 - **открытый ключ получателя**
 - свой закрытый ключ

Функция, которую можно использовать в криптосистеме с открытым ключом, должна обладать следующими свойствами:
-------------------------------------------------------------------------------------------------------------
 - не иметь обратной функции
 - вычисление обратной функции должно иметь полиномиальную сложность без знания дополнительной информации
 - **вычисление обратной функции должно иметь экспоненциальную сложность без знания дополнительной информации и полиномиальную сложность, если эта информация известна**

Теорема Ферма формулируется следующим образом
---------------------------------------------
 - если р – простое, то число положительных чисел, меньших р и взаимнопростых с р, равно р-1
 - aΦ(n) ≡ 1 mod n для всех взаимнопростых a и n, где Φ(n) - число положительных чисел, меньших n и взаимнопростых с n
 - **an-1 ≡ 1 mod n, если n - простое**

Теорема Эйлера формулируется следующим образом
----------------------------------------------
 - если р – простое, то число положительных чисел, меньших р и взаимнопростых с р, равно р-1
 - **aΦ(n) ≡ 1 mod n для всех взаимнопростых a и n, где Φ(n) - число положительных чисел, меньших n и взаимнопростых с n**
 - an-1 ≡ 1 mod n, если n - простое

Алгоритм Диффи-Хеллмана дает возможность
----------------------------------------
 - безопасно обменяться общим секретом
 - **безопасно обменяться общим секретом при условии аутентификации сторон**
 - подписать сообщение

Алгоритм RSA основан на
-----------------------
 - задаче дискретного логарифмирования
 - **задаче факторизации числа**
 - задаче определения, является ли данное число простым

Задачей дискретного логарифмирования является
---------------------------------------------
 - разложение числа на простые сомножители
 - **нахождение степени, в которую следует возвести целое число для получения заданного целого числа**
 - нахождение степени, в которую следует возвести простое число для получения заданного целого числа

Для создания подписи следует использовать
-----------------------------------------
 - свой открытый ключ
 - закрытый ключ  получателя
 - **свой закрытый ключ**

Алгоритм Диффи-Хеллмана основан на
----------------------------------
 - **задаче дискретного логарифмирования**
 - задаче факторизации числа
 - задаче определения, является ли данное число простым

Аутентификация сторон в алгоритме Диффи-Хеллмана необходима, потому что
-----------------------------------------------------------------------
 - в противном случае возможен взлом задачи дискретного логарифмирования
 - в противном случае возможен взлом задачи факторизации числа
 - **в противном случае нарушитель может заменить пересылаемые открытые ключи на свой открытый ключ**

Аутентификация сторон в алгоритме Диффи-Хеллмана необходима, потому что
-----------------------------------------------------------------------
 - **в противном случае атакующий может перехватить передаваемые открытые ключи и заменить их своим открытым ключом**
 - в противном случае атакующий может взломать дискретный логарифм
 - в противном случае стороны не смогут вычислить общий секрет

Функция Эйлера – это
--------------------
 - **число положительных чисел, меньших n и взаимнопростых с n**
 - aΦ (n) ≡ 1 mod n для всех взаимнопростых a и n, где Φ(n) - число положительных чисел, меньших n и взаимнопростых с n
 - an-1  ≡ 1 mod n, если n - простое

Задачей факторизации числа является
-----------------------------------
 - **разложение числа на простые сомножители**
 - нахождение степени, в которую следует возвести целое число для получения заданного целого числа
 - нахождение степени, в которую следует возвести простое число для получения заданного целого числа

Длина ключа в алгоритме Rijndael может быть
-------------------------------------------
 - **128 бит**
 - **192 бита**
 - **256 бит**

Раунд алгоритма Rijndael имеет
------------------------------
 - 3 слоя
 - **4 слоя**
 - 5 слоев

Выберите правильное высказывание
--------------------------------
 - в алгоритме Rijndael отсутствует забеливание
 - в алгоритме Rijndael забеливание выполняется без использования ключа
 - **в алгоритме Rijndael забеливание выполняется с использованием ключа**

Число раундов в алгоритме Rijndael
----------------------------------
 - постоянное и равно 14
 - постоянное и равно 12
 - **переменное и зависит от длины ключа и длины блока**

Какому полиному соответствует шестнадцатеричное число 21
--------------------------------------------------------
 - x6 + 1
 - **x5 + 1**
 - x7 + x5 + 1

В алгоритме Rijndael слой SubByte является
------------------------------------------
 - преобразованием, при котором строки состояния циклически сдвигаются на различные значения
 - побитовым XOR ключа раунда с текущим состоянием
 - **нелинейной байтовой подстановкой, выполняющейся для каждого байта состояния независимо**

Выберите правильное утверждение
-------------------------------
 - в основе алгоритма RС6 лежит традиционная сеть Фейштеля
 - в основе алгоритма RС6 не лежит сеть Фейштеля
 - **в основе алгоритма RС6 лежит сеть Фейштеля смешанного типа с 4 ветвями**

Выберите правильное утверждение
-------------------------------
 - в основе алгоритма Rijndael лежит традиционная сеть Фейштеля
 - **в основе алгоритма Rijndael не лежит сеть Фейштеля**
 - в основе алгоритма Rijndael лежит сеть Фейштеля смешанного типа с 4 ветвями

В алгоритме RC6 используются следующие операции
-----------------------------------------------
 - **XOR слов**
 - **циклический сдвиг на несколько битов**
 - S-box

S-box в алгоритме Rijndael отображает
-------------------------------------
 - **1 байт в 1 байт**
 - 6 бит в 4 бита
 - 6 байт в 4 байта

Какому полиному соответствует шестнадцатеричное число 3A
--------------------------------------------------------
 - **x5 + x4 + x3 + x**
 - x6 + x5 + x3 + x
 - x2 + 1

Алгоритм Twofish обладает следующим свойством
---------------------------------------------
 - имеет самое быстрое установление ключа
 - имеет самое быстрое шифрование/дешифрование
 - **имеет возможность вычисления подключей на лету**

Алгоритм Serpent обладает следующими свойствами
-----------------------------------------------
 - имеет самое быстрое установление ключа
 - имеет самое быстрое шифрование/дешифрование
 - **имеет возможность вычисления подключей на лету**
 - шифрование и дешифрование имеют идентичные функции

Самое быстрое установление ключа
--------------------------------
 - **Rijndael**
 - MARS
 - Serpent
 - RC6
 - Twofish

Алгоритм RC6 обладает следующими свойствами
-------------------------------------------
 - имеет самое быстрое установление ключа
 - **имеет самое быстрое шифрование/дешифрование**
 - **имеет возможность вычисления подключей на лету**
 - **шифрование и дешифрование имеют идентичные функции**

Окружениям с ограничениями пространства соответствуют алгоритмы
---------------------------------------------------------------
 - **RC6**
 - **Rijndael**
 - **Serpent**
 - **Twofish**

Алгоритм MARS обладает следующими свойствами
--------------------------------------------
 - имеет самое быстрое установление ключа
 - имеет самое быстрое шифрование/дешифрование
 - имеет возможность вычисления подключей на лету
 - **шифрование и дешифрование имеют идентичные функции**

Какие из финалистов  продемонстрировали адекватную AES безопасность
-------------------------------------------------------------------
 - **MARS**
 - **Twofish**
 - **Rijndael**
 - **Serpent**
 - **RC6**

Возможность вычисления подключей на лету существует в алгоритмах
----------------------------------------------------------------
 - **RC6**
 - **Twofish**
 - **Rijndael**
 - **Serpent**

Алгоритм Serpent характеризуется следующими свойствами
------------------------------------------------------
 - **имеет длину блока 128 бит**
 - основан на сети Фейштеля
 - **использует S-boxes**

Алгоритм Rijndael характеризуется следующими свойствами
-------------------------------------------------------
 - **имеет длину блока 128 бит**
 - основан на сети Фейштеля
 - **использует S-boxes**

Алгоритм Twofish характеризуется следующими свойствами
------------------------------------------------------
 - **имеет длину блока 128 бит**
 - **основан на сети Фейcтеля**
 - **использует S-boxes**

S-boxes существуют в следующих алгоритмах
-----------------------------------------
 - **Rijndael**
 - **MARS**
 - **Serpent**
 - RC6
 - **Twofish**

Общее число финалистов AES
--------------------------
 - 15
 - **5**
 - 1

Длина блока алгоритма AES должна быть не меньше
-----------------------------------------------
 - 64 бит
 - **128 бит**
 - 256 бит

Алгоритм RC6 характеризуется следующими свойствами
--------------------------------------------------
 - **имеет длину блока 128 бит**
 - **основан на сети Фейcтеля**
 - использует S-boxes

Главным требованием к алгоритму, принимаемому в качестве стандарта AES, была
----------------------------------------------------------------------------
 - низкая стоимость алгоритма
 - простота алгоритма
 - эффективность выполнения алгоритма на различных архитектурах
 - **безопасность алгоритма**

Под резервом безопасности понимают
----------------------------------
 - **отношение числа раундов полного алгоритма к уменьшенному числу раундов, для которого существует атака**
 - на сколько бит длина ключа алгоритма больше 256
 - на сколько бит длина блока алгоритма больше 64

Последовательность случайных чисел должна быть
----------------------------------------------
 - монотонно возрастающей
 - монотонно убывающей
 - **иметь равномерное распределение**

Длина ключа в алгоритме IDEA
----------------------------
 - 56 бит
 - **128 бит**
 - 256 бит
 - 448 бит

Для передачи больших сообщений лучше всего соответствует режим
--------------------------------------------------------------
 - ECB
 - **CBC**
 - CFB
 - OFB

Выберите правильное высказывание
--------------------------------
 - алгоритм Blowfish использует постоянные S-boxes
 - **алгоритм Blowfish использует переменные S-boxes, зависящие от ключа**
 - алгоритм Blowfish не использует S-boxes

Алгоритм Blowfish
-----------------
 - **имеет переменную длину ключа**
 - **основан на сети Фейштеля**
 - имеет фиксированные S-box

Режим СВС используется для того, чтобы
--------------------------------------
 - **одинаковые незашифрованные блоки преобразовывались в различные зашифрованные блоки**
 - не было необходимости разбивать сообщение на целое число блоков достаточно большой длины
 - увеличить скорость шифрования

