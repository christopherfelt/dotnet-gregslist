use cftestdb1;

-- CREATE TABLE cars (
--     id INT NOT NULL AUTO_INCREMENT,
--     title VARCHAR(255) NOT NULL,
--     description VARCHAR(255) DEFAULT "",
--     price FLOAT(8, 2) DEFAULT 00.00,
--     imgurl VARCHAR(255) DEFAULT "//placehold.it/200x200",
--     PRIMARY KEY(id)
-- )

-- CREATE TABLE jobs (
--     id INT NOT NULL AUTO_INCREMENT,
--     title VARCHAR(255) NOT NULL,
--     description VARCHAR(255) DEFAULT "",
--     hours INT DEFAULT 0,
--     rate FLOAT(8, 2) DEFAULT 00.00,
--     imgurl VARCHAR(255) DEFAULT "//placehold.it/200x200",
--     PRIMARY KEY(id)
-- )

-- CREATE TABLE houses (
--     id INT NOT NULL AUTO_INCREMENT,
--     title VARCHAR(255) NOT NULL,
--     description VARCHAR(255) DEFAULT "",
--     price FLOAT(10, 2) DEFAULT 00.00,
--     location VARCHAR(255) DEFAULT "",
--     imgurl VARCHAR(255) DEFAULT "//placehold.it/200x200",
--     PRIMARY KEY(id)
-- )


-- INSERT INTO houses
-- (title, description, price, location)
-- VALUES
-- ("test1", "testing from sql", 232332.45, "Boise")

-- DROP TABLE IF EXISTS houses

select * from houses