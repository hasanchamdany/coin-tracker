create sequence wallet_id start 001
create table tb_wallet
(
	id character varying(100) default 'W' || nextval('wallet_id') primary key,
	wallet_name character varying(40),
	amount integer
)