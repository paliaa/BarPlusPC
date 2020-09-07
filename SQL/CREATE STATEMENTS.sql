CREATE TABLE t_products (
	id int NOT NULL AUTO_INCREMENT,
    p_id int,
    p_name varchar(255),
    p_groupid int,
    p_price decimal(6,2),
    p_ivaid int,
    PRIMARY KEY (`id`)
);

CREATE TABLE t_iva (
    i_id int,
    i_name varchar(255),
    i_value int
);

CREATE TABLE t_group (
    g_id int,
    g_name varchar(255)
);

