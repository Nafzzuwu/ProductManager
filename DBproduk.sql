CREATE TABLE produk (
    product_id SERIAL PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL,
    category VARCHAR(50) NOT NULL,
    price NUMERIC(12, 2) NOT NULL,
    stock INTEGER NOT NULL
);

INSERT INTO produk (product_id, product_name, category, price, stock)
VALUES
('1', 'Asus ROG', 'Laptop', '15000000', '8')
