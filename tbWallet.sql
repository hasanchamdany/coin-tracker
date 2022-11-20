-- insert function --
create or replace function wallet_insert
(
	_wallet_name character varying,
	_amount integer

)
returns int as
'
begin
	insert into public.tb_wallet
	(
		wallet_name,
		amount
		
	)
	values
	(
		_wallet_name,
		_amount
		
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql;

-- select function --
create function wallet_select()
returns table
(
	_wallet_name character varying,
	_amount integer
)
language plpgsql
as
'
begin
	return query
	select wallet_name, amount from tb_wallet;
end
'

-- update function --
create or replace function wallet_update
(
	_id character varying,
	_wallet_name character varying
)
returns int as
'
begin
	update tb_wallet set
		wallet_name = _wallet_name
	where id = _id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql

-- delete function --
create or replace function wallet_delete(_id character varying)
returns int as
'
begin
	delete from public.tb_wallet
	where id = _id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql

drop function if exists wallet_update(character varying);