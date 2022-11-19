create sequence wallet_id start 001
create table tb_wallet
(
	id character varying(100) default 'W' || nextval('wallet_id') primary key,
	wallet_name character varying(40),
	amount integer
)

create sequence transaction_id start 001
create table tb_transaction
(
	id character varying(100) default 'TR' || nextval('transaction_id') primary key,
	transaction_type character varying(200),
	wallet_name character varying(200),
	category_name character varying(200),
	date_tr character varying()
	amount integer
)