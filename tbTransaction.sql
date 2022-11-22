-- insert function --
create function transaction_insert
(
	-- _wallet_name character varying

    _transaction_type character varying,
    _wallet_name character varying,
    _category_name character varying,
    _date_tr character varying,
    _amount integer

)
returns int as
'
begin
	insert into public.tb_transaction
	(
        transaction_type,
        wallet_name,
        category_name,
        date_tr,
        amount
		
	)
	values
	(
        _transaction_type,
		_wallet_name,
        _category_name,
        _date_tr,
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
create function transaction_select()
returns table
(
    _id character varying,
	_transaction_type character varying,
    _wallet_name character varying,
    _category_name character varying,
    _date_tr character varying,
    _amount integer
)
language plpgsql
as
'
begin
	return query
	select id, transaction_type, wallet_name, category_name, date_tr, amount from tb_transaction;
end
'

-- update function --
create or replace function transaction_update
(
	-- _id character varying,
	-- _wallet_name character varying

    _id character varying,
	_transaction_type character varying,
    _wallet_name character varying,
    _category_name character varying,
    _date_tr character varying,
    _amount integer    
)
returns int as
'
begin
	update tb_transaction set
        transaction_type = _transaction_type,
		wallet_name = _wallet_name,
        category_name = _category_name,
        date_tr = _date_tr,
        amount = _amount
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
create or replace function transaction_delete(_id character varying)
returns int as
'
begin
	delete from public.tb_transaction
	where id = _id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql


-- delete wallet by name --
create or replace function transaction_delete_wallet(_wallet_name character varying)
returns int as
'
begin
	delete from public.tb_transaction
	where wallet_name = _wallet_name;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql

-- update transaction wallet name --
create or replace function transaction_update
(
	-- _id character varying,
	-- _wallet_name character varying

    _id character varying,
	_transaction_type character varying,
    _wallet_name character varying,
    _category_name character varying,
    _date_tr character varying,
    _amount integer    
)
returns int as
'
begin
	update tb_transaction set
        transaction_type = _transaction_type,
		wallet_name = _wallet_name,
        category_name = _category_name,
        date_tr = _date_tr,
        amount = _amount
	where id = _id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql


-- update transaction wallet name --
create or replace function transaction_update_wallet
(
    _old_wallet_name character varying,
    _new_wallet_name character varying    
)
returns int as
'
begin
	update tb_transaction set
		wallet_name = _new_wallet_name
	where wallet_name = _old_wallet_name;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql
