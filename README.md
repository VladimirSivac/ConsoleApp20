# 🎫 Lucky Ticket Validator 

Программа для проверки шестизначных билетов по алгоритму "счастливого номера" с цветным выводом.

## ✨ Особенности
- 🔍 Проверка ввода (только 6-значные числа)
- 🎨 Цветовая индикация результатов (зеленый/красный)
- ❌ Обработка некорректных данных

## 📚 Теоретическая справка
Счастливый билет — номер, где:
(a + b + c) == (d + e + f)
Для номера формата abcdef (6 цифр).

Примеры:

123321 → (1+2+3) = (3+2+1) = 6 ✅

123456 → (1+2+3) ≠ (4+5+6) ≠ 15 ❌

## 🖥 Пример работы
```text
Введите шестизначный номер билета: 123456

У Вас обычный билет
------------------------------
Введите шестизначный номер билета: 123321

Ура, у Вас счастливый билет!
