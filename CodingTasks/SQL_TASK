CREATE TABLE clients (
    client_id     NUMBER PRIMARY KEY,
    client_name   VARCHAR2(500)
);
/

CREATE TABLE orders (
    order_id     NUMBER PRIMARY KEY,
    client_id    NUMBER REFERENCES clients ( client_id ),
    order_sum    NUMBER,
    order_date   DATE
);
/
--a--
SELECT
    c.*
FROM
    clients c
    JOIN orders o ON o.client_id = c.client_id
                     AND o.order_sum > 50;

--b--
SELECT
    c.*
FROM
    clients c
    JOIN orders o ON o.client_id = c.client_id
GROUP BY
    c.client_id,
    c.client_name
HAVING
    SUM(o.order_sum) > 100;
