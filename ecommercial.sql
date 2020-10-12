--
-- PostgreSQL database dump
--

-- Dumped from database version 13.0
-- Dumped by pg_dump version 13.0

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: invoice_type_enum; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.invoice_type_enum AS ENUM (
    'individual',
    'institutional'
);


ALTER TYPE public.invoice_type_enum OWNER TO postgres;

--
-- Name: order_product_state_enum; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.order_product_state_enum AS ENUM (
    'canceled-by-shop',
    'canceled-by-user',
    'waiting-for-payment',
    'onreply',
    'ready-for-shipping',
    'oncargo-touser',
    'concluded-success',
    'concluded-damaged',
    'concluded-return',
    'concluded-missing-piece',
    'concluded-wrong-piece',
    'concluded-not-be-delivered',
    'system-control',
    'oncargo-toshop'
);


ALTER TYPE public.order_product_state_enum OWNER TO postgres;

--
-- Name: product_warranty_type_enum; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.product_warranty_type_enum AS ENUM (
    'day',
    'month',
    'year'
);


ALTER TYPE public.product_warranty_type_enum OWNER TO postgres;

--
-- Name: shop_firm_profile_enum; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.shop_firm_profile_enum AS ENUM (
    'distributor',
    'importer',
    'main dealer',
    'dealer',
    'producer'
);


ALTER TYPE public.shop_firm_profile_enum OWNER TO postgres;

--
-- Name: shop_firm_type_enum; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.shop_firm_type_enum AS ENUM (
    'private',
    'incorporated',
    'sole-proprietorship',
    'ordinary-partnership',
    'foundation'
);


ALTER TYPE public.shop_firm_type_enum OWNER TO postgres;

--
-- Name: shop_product_state_enum; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.shop_product_state_enum AS ENUM (
    'onsale',
    'onstock'
);


ALTER TYPE public.shop_product_state_enum OWNER TO postgres;

--
-- Name: is_shop_or_user_id(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.is_shop_or_user_id(ident bigint) RETURNS boolean
    LANGUAGE sql
    AS $$
SELECT EXISTS (SELECT id
			  FROM shops 
			  WHERE id=ident) OR EXISTS (SELECT id
										FROM users
										WHERE id=ident)
$$;


ALTER FUNCTION public.is_shop_or_user_id(ident bigint) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: addresses; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.addresses (
    id integer NOT NULL,
    user_or_shop_id integer NOT NULL,
    receiver_name character varying(40) NOT NULL,
    receiver_surname character varying(40) NOT NULL,
    receiver_number bigint NOT NULL,
    city_id integer NOT NULL,
    address character varying(250) NOT NULL,
    name character varying(30) NOT NULL,
    CONSTRAINT user_or_shop_id CHECK (public.is_shop_or_user_id((user_or_shop_id)::bigint))
);


ALTER TABLE public.addresses OWNER TO postgres;

--
-- Name: addresses_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.addresses ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.addresses_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: banks; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.banks (
    id smallint NOT NULL,
    name character varying(128) NOT NULL,
    address character varying(255),
    telephone character varying(16),
    fax character varying(16),
    web character varying(64),
    telex character varying(32),
    eft character varying(4),
    swift character varying(16)
);


ALTER TABLE public.banks OWNER TO postgres;

--
-- Name: banks_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.banks ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.banks_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: brands; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.brands (
    id integer NOT NULL,
    brand character varying(200) NOT NULL
);


ALTER TABLE public.brands OWNER TO postgres;

--
-- Name: brands_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.brands ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.brands_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: campaigns; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.campaigns (
    id integer NOT NULL,
    start_datetime timestamp without time zone NOT NULL,
    end_datetime timestamp without time zone NOT NULL,
    rate numeric(2,2) NOT NULL
);


ALTER TABLE public.campaigns OWNER TO postgres;

--
-- Name: campaigns_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.campaigns ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.campaigns_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: categories; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.categories (
    id smallint NOT NULL,
    title character varying(50) NOT NULL
);


ALTER TABLE public.categories OWNER TO postgres;

--
-- Name: categories_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.categories ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.categories_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: cities; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cities (
    id smallint NOT NULL,
    name text NOT NULL
);


ALTER TABLE public.cities OWNER TO postgres;

--
-- Name: cities_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.cities ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.cities_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: coupons; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.coupons (
    id integer NOT NULL,
    amount integer NOT NULL
);


ALTER TABLE public.coupons OWNER TO postgres;

--
-- Name: coupons_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.coupons ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.coupons_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: districts; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.districts (
    id smallint NOT NULL,
    name text NOT NULL,
    city_id smallint NOT NULL
);


ALTER TABLE public.districts OWNER TO postgres;

--
-- Name: districts_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.districts ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.districts_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: faq_categories; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.faq_categories (
    id smallint NOT NULL,
    title character varying(50) NOT NULL
);


ALTER TABLE public.faq_categories OWNER TO postgres;

--
-- Name: faq_categories_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.faq_categories ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.faq_categories_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: faq_subcategories; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.faq_subcategories (
    id smallint NOT NULL,
    faq_category_id smallint NOT NULL,
    title character varying(100) NOT NULL
);


ALTER TABLE public.faq_subcategories OWNER TO postgres;

--
-- Name: faq_subcategories_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.faq_subcategories ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.faq_subcategories_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: faqs; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.faqs (
    id smallint NOT NULL,
    faq_subcategory_id smallint NOT NULL,
    title character varying(50) NOT NULL,
    content character varying(5000) NOT NULL
);


ALTER TABLE public.faqs OWNER TO postgres;

--
-- Name: faqs_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.faqs ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.faqs_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: general_infos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.general_infos (
    facebook_address character varying(100),
    twitter_address character varying(100),
    instagram_address character varying(100),
    linkedin_address character varying(100),
    pinterest_address character varying(100),
    youtube_address character varying(100),
    logo_url character varying(250),
    whatsapp_number bigint
);


ALTER TABLE public.general_infos OWNER TO postgres;

--
-- Name: invoices; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.invoices (
    id integer NOT NULL,
    user_id integer,
    invoicee_name character varying(40) NOT NULL,
    invoicee_surname character varying(40) NOT NULL,
    invoicee_number bigint NOT NULL,
    city_id smallint NOT NULL,
    address character varying(250) NOT NULL,
    name character varying(30) NOT NULL,
    type public.invoice_type_enum
);


ALTER TABLE public.invoices OWNER TO postgres;

--
-- Name: invoices_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.invoices ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.invoices_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: order_products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.order_products (
    id integer NOT NULL,
    order_id integer NOT NULL,
    product_id integer NOT NULL,
    count integer,
    state public.order_product_state_enum NOT NULL
);


ALTER TABLE public.order_products OWNER TO postgres;

--
-- Name: order_products_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.order_products ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.order_products_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.orders (
    id smallint NOT NULL,
    user_id integer NOT NULL,
    claim_address_id integer NOT NULL,
    invoice_id integer NOT NULL,
    datetime timestamp without time zone NOT NULL
);


ALTER TABLE public.orders OWNER TO postgres;

--
-- Name: orders_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.orders ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.orders_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: product_campaigns; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.product_campaigns (
    id integer NOT NULL,
    product_id integer NOT NULL,
    campaign_id integer NOT NULL
);


ALTER TABLE public.product_campaigns OWNER TO postgres;

--
-- Name: product_campaigns_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.product_campaigns ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.product_campaigns_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: product_rates; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.product_rates (
    id integer NOT NULL,
    product_id integer NOT NULL,
    user_id integer NOT NULL,
    comment character varying(3000) DEFAULT ''::character varying,
    rate smallint NOT NULL,
    images character varying(250)[] DEFAULT '{}'::character varying[],
    hid_user_info_enabled boolean NOT NULL,
    datetime timestamp without time zone NOT NULL
);


ALTER TABLE public.product_rates OWNER TO postgres;

--
-- Name: product_rates_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.product_rates ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.product_rates_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.products (
    id integer NOT NULL,
    barcode bigint NOT NULL,
    subsubcategory_id integer NOT NULL,
    brand_id integer NOT NULL,
    name character varying(250) NOT NULL,
    vat_rate numeric(2,2) NOT NULL,
    expiry smallint NOT NULL,
    commission numeric(2,2) DEFAULT 0,
    warranty_period smallint DEFAULT 0,
    warranty_type public.product_warranty_type_enum NOT NULL,
    description text DEFAULT ''::text,
    properties character varying(200)[] DEFAULT '{}'::character varying[],
    cargo_corporation character varying(50) NOT NULL,
    deci smallint NOT NULL
);


ALTER TABLE public.products OWNER TO postgres;

--
-- Name: products_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.products ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.products_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: shop_products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.shop_products (
    id integer NOT NULL,
    shop_id integer NOT NULL,
    product_id integer NOT NULL,
    variant_group_id integer,
    product_rating numeric(2,2) DEFAULT 0.00,
    rating_count integer DEFAULT 0,
    stock_amount integer DEFAULT 0,
    stock_code character varying(10),
    price numeric(20,2) NOT NULL,
    day_for_cargo smallint NOT NULL,
    images character varying(250)[] DEFAULT '{}'::character varying[],
    release_datetime timestamp without time zone NOT NULL,
    state public.shop_product_state_enum
);


ALTER TABLE public.shop_products OWNER TO postgres;

--
-- Name: shop_products_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.shop_products ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.shop_products_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: shops; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.shops (
    id integer NOT NULL,
    username character varying(30) NOT NULL,
    password character varying(16) NOT NULL,
    shop_owner_name character varying(40) NOT NULL,
    authorized_name character varying(40) NOT NULL,
    authorized_surname character varying(40) NOT NULL,
    authorized_gender boolean NOT NULL,
    authorized_position character varying(30) NOT NULL,
    authorized_phone bigint NOT NULL,
    authorized_email character varying(50) NOT NULL,
    firm_owner_name character varying(20) NOT NULL,
    firm_owner_surname character varying(20) NOT NULL,
    firm_owner_phone bigint NOT NULL,
    kep_mail character varying(50) NOT NULL,
    firm_website character varying(50),
    firm_email character varying(50) NOT NULL,
    legal_firm_name character varying(50) NOT NULL,
    firm_type public.shop_firm_type_enum NOT NULL,
    firm_profile public.shop_firm_profile_enum NOT NULL,
    selling_subcategory_id integer NOT NULL,
    commercial_record_number integer,
    tax_office_city_id smallint NOT NULL,
    tax_office_id smallint NOT NULL,
    tax_or_trid_number bigint NOT NULL,
    mersis_number bigint NOT NULL,
    firm_fixed_phone bigint NOT NULL,
    invoice_address character varying(250) NOT NULL,
    invoice_city_id smallint NOT NULL,
    invoice_district_id smallint NOT NULL,
    invoice_email character varying(50) NOT NULL,
    bank_account_owner character varying(40) NOT NULL,
    bank_id smallint NOT NULL,
    branch_bank_name character varying(128) NOT NULL,
    branch_code smallint NOT NULL,
    account_number bigint NOT NULL,
    iban bigint NOT NULL
);


ALTER TABLE public.shops OWNER TO postgres;

--
-- Name: shops_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.shops ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.shops_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: slides; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.slides (
    id integer NOT NULL,
    image_url character varying(250) NOT NULL,
    route_url character varying(250),
    slide_order smallint DEFAULT 0
);


ALTER TABLE public.slides OWNER TO postgres;

--
-- Name: slides_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.slides ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.slides_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: subcategories; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.subcategories (
    id smallint NOT NULL,
    category_id smallint NOT NULL,
    title character varying(50) NOT NULL
);


ALTER TABLE public.subcategories OWNER TO postgres;

--
-- Name: subcategories_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.subcategories ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.subcategories_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: subsubcategories; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.subsubcategories (
    id smallint NOT NULL,
    subcategory_id smallint NOT NULL,
    title character varying(50) NOT NULL
);


ALTER TABLE public.subsubcategories OWNER TO postgres;

--
-- Name: subsubcategories_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.subsubcategories ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.subsubcategories_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tax_offices; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tax_offices (
    id smallint NOT NULL,
    city_id smallint NOT NULL,
    district_id smallint NOT NULL,
    accounting_unit_code integer NOT NULL,
    name text NOT NULL
);


ALTER TABLE public.tax_offices OWNER TO postgres;

--
-- Name: tax_offices_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tax_offices ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.tax_offices_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: user_coupons; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.user_coupons (
    id integer NOT NULL,
    coupon_id integer NOT NULL,
    user_id integer NOT NULL
);


ALTER TABLE public.user_coupons OWNER TO postgres;

--
-- Name: user_coupons_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.user_coupons ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.user_coupons_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: user_favourite_products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.user_favourite_products (
    id integer NOT NULL,
    user_id integer NOT NULL,
    product_id integer NOT NULL
);


ALTER TABLE public.user_favourite_products OWNER TO postgres;

--
-- Name: user_favourite_products_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.user_favourite_products ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.user_favourite_products_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: user_products_will_be_ordered; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.user_products_will_be_ordered (
    id integer NOT NULL,
    user_id integer NOT NULL,
    product_id integer NOT NULL
);


ALTER TABLE public.user_products_will_be_ordered OWNER TO postgres;

--
-- Name: user_products_will_be_ordered_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.user_products_will_be_ordered ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.user_products_will_be_ordered_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id integer NOT NULL,
    email character varying(50) NOT NULL,
    name character varying(40) NOT NULL,
    surname character varying(40) NOT NULL,
    phone bigint NOT NULL,
    birthdate timestamp without time zone NOT NULL,
    gender boolean NOT NULL,
    email_notification_enabled boolean NOT NULL,
    sms_notification_enabled boolean NOT NULL
);


ALTER TABLE public.users OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.users ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.users_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Data for Name: addresses; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.addresses (id, user_or_shop_id, receiver_name, receiver_surname, receiver_number, city_id, address, name) FROM stdin;
\.


--
-- Data for Name: banks; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.banks (id, name, address, telephone, fax, web, telex, eft, swift) FROM stdin;
1	Adabank A.Ş.	Büyükdere Cad. Rumelihan No 40 Kat 2 Mecidiyeköy İstanbul	212-2726420	212-2726446	http://www.adabank.com.tr	27282 adb TR	0100	ADABTRIS
2	Akbank T.A.Ş.	Sabancı Center 4. Levent İstanbul	212-3855555	212-2697383	http://www.akbank.com	26449 aktc TR	0046	AKBKTRIS
3	Aktif Yatırım Bankası A.Ş.	Büyükdere Cad. No 163 Zincirlikuyu Şişli İstanbul	212-3408000	212-3408987	http://www.aktifbank.com.tr	\N	0143	CAYTTRIS
4	Alternatifbank A.Ş.	Cumhuriyet Caddesi No. 46 Elmadağ Şişli İstanbul	212-3156500	212-2331500	http://www.abank.com.tr	26191 ALFBTRIS	0124	ALFBTRIS
5	Anadolubank A.Ş.	Cumhuriyet Mah. Silahşör Cad. No 69 Bomonti Şişli İstanbul	212-3687000	212-2965715	http://www.anadolubank.com.tr	\N	0135	ANDLTRIS
6	Arap Türk Bankası A.Ş.	Valikonağı Cad. No 10 Nişantaşı İstanbul	212-225050020	212-225052622499	http://www.atbank.com.tr	26830 atbk TR	0091	ATUBTRIS
7	Bank Mellat	Büyükdere Cad. Binbirçiçek Sok. No 1 1.Levent İstanbul	212-2798015	212-284621428466	http://www.mellatbank.com	26502 melt TR	0094	BKMTTRIS
8	Bank of Tokyo-Mitsubishi UFJ Turkey A.Ş.	Fatih Sultan Mehmet Mahallesi, Poligon Caddesi Buyaka 2 Sitesi No: 8B C-Blok, Kat: 20-21 Tepeüstü Ümraniye İstanbul	216-6003000	216-2906473	http://www.tu.bk.mufg.jp	\N	0147	BOTKTRIS
9	BankPozitif Kredi ve Kalkınma Bankası A.Ş.	Rüzgarlıbahçe Mah. Kayın Sok. No.3 Kavacık Beykoz İstanbul	216-5382525	216-5384258	http://www.bankpozitif.com.tr	\N	0142	BPTRTRIS
10	Birleşik Fon Bankası A.Ş.	Büyükdere Cad. No 143 Kat 1-2 Esentepe Şişli İstanbul	212-3401000	212-3473217	http://www.fonbank.com.tr	27920 dev TR	0029	BAYDTRIS
11	Burgan Bank A.Ş.	Esentepe Mah. Büyükdere Cad. No 209, Tekfen Tower, Şişli İstanbul	212-3713737	212-3714242	http://www.burgan.com.tr	\N	0125	TEKFTRIS
12	Citibank A.Ş.	Saray Mahallesi Ömer Faik Atakan Caddesi, No 3 Yılmaz Plaza Ümraniye İstanbul	216-5245000	216-5245050	http://www.citibank.com.tr	26277 citi TR	0092	CITITRIX
13	Denizbank A.Ş.	Büyükdere Cad. No 141 Esentepe Şişli İstanbul	212-3482000	212-3363030	http://www.denizbank.com	\N	0134	DENITRIS
14	Deutsche Bank A.Ş.	Esentepe Mah. Büyükdere Cad. Tekfen Tower, No 209 K:17-18 Şişli İstanbul	212-3170100	212-3170105	http://www.db.com.tr	39343 tmch tr.	0115	BKTRTRIS
15	Diler Yatırım Bankası A.Ş.	Tersane Cad. No 96 Diler Han Kat 8 Karaköy İstanbul	212-2536630	212-2539454	http://www.dilerbank.com.tr	\N	0138	DYAKTRIS
16	Fibabanka A.Ş.	Emirhan Caddesi Barbaros Plaza  Merkezi No 113 Dikilitaş  Beşiktaş İstanbul	212-3818200	212-2583778	http://www.fibabanka.com.tr	\N	0103	FBHLTRIS
17	Finans Bank A.Ş.	Esentepe Mah. Büyükdere Cad. Kristal Kule Binası No 215 Şişli İstanbul	212-3185000	212-3185850	http://www.finansbank.com.tr	398242 fnb tr	0111	FNNBTRIS
18	GSD Yatırım Bankası A.Ş.	Aydınevler Mah. Kaptan Rıfat Sokak. No 3 GSD Binası No 14 Küçükyalı  Maltepe İstanbul	216-5879000	216-4899774	http://www.gsdbank.com.tr	\N	0139	GSDBTRIS
19	Habib Bank Limited	Abide-i Hürriyet Cad. Geçit Sok. No 6/A Şişli İstanbul	212-246022024602	212-2340807	http://www.habibbank.com.tr	27849 hbl TR	0097	HABBTRIS
20	HSBC Bank A.Ş.	Esentepe Mah. Büyükdere Cad. No 128 Şişli İstanbul	212-3764000	212-3362939	http://www.hsbc.com.tr	38385 mdn TR	0123	HSBCTRIX
21	ING Bank A.Ş.	Reşitpaşa Mahallesi Eski Büyükdere Cad. No 8 Sarıyer İstanbul	212-3351000	212-2866100	http://www.ingbank.com.tr	\N	0099	INGBTRIS
22	Intesa Sanpaolo S.p.A.	Meltem Sokak, No: 10  Kuleleri, Kule 2,Kat: 21 Levent Beşiktaş İstanbul	212-3850600	212-3850649	http://www.intesasanpaolo.com.tr	\N	0148	BCITTRIS
23	İller Bankası A.Ş.	Ziraat Mah. 657 Sok. No 14 Dışkapı Ankara	312-508700030330	312-508739931074	http://www.ilbank.gov.tr	42723 gnmd tr	0004	
24	İstanbul Takas ve Saklama Bankası A.Ş.	Şişli Merkez Mahallesi, Merkez Caddesi, No 6 Şişli İstanbul	212-3152525	212-3152526	http://www.takasbank.com.tr	\N	0132	TVSBTRIS
25	JPMorgan Chase Bank N.A.	Büyükdere Cad. No 185 Kanyon Ofis Binası Kat 8 Levent İstanbul	212-3198500	212-3198664	http://www.jpmorgan.com/pages/international/turkey	26625 cmb TR	0098	CHASTRIS
26	Merrill Lynch Yatırım Bank A.Ş.	Büyükdere Cad. No 185 Kanyon Ofisi Bloğu 11. Kat Levent İstanbul	212-3199500	212-3199511	http://www.mlyb.com.tr	25849 tayb TR	0129	MEYYTRISXXX
27	Nurol Yatırım Bankası A.Ş.	Maslak Mah. Büyükdere Cad. Nurol Plaza No 257 B Blok, Kat 15 Maslak  Şişli İstanbul	212-2868100	212-2868101	http://www.nurolbank.com.tr	\N	0141	NUROTRIS
28	Odea Bank A.Ş.	Levent 199, Büyükdere Cad. No 199, Kat 33-39 Şişli İstanbul	212-3048444	212-3048445	http://www.odeabank.com.tr	\N	0146	ODEATRIS
29	Pasha Yatırım Bankası A.Ş.	Maslak Mah. A.O.S. 55. Sok. No 2 42 Maslak Ofis 3 Kat 7 Daire 205 Sarıyer İstanbul	212-7058900	212-3450712	http://www.pashabank.com.tr	26475 yatb TR	0116	TAIBTRIS
30	Rabobank A.Ş.	Esentepe Mah. Büyükdere Cad. Bahar Sok. River Plaza No: 13 K: 7 Ofis No:15-16 Şişli İstanbul	212-7084600	212-7084699	http://www.rabobank.com.tr	\N	0137	RABOTRIS
31	Société Générale (SA)	Nispetiye Cad. Akmerkez E-3 Blok Kat 10 Etiler İstanbul	212-3193400	212-282184828218	http://www.sgcib.com.tr	SOGETRIS	0122	SOGETRIS
32	Standard Chartered Yatırım Bankası Türk A.Ş.	Büyükdere Cad. Yapı Kredi Plaza, C Blok, Kat 15 Levent İstanbul	212-3393700	212-2826301	http://www.standardchartered.com.tr	\N	0121	BSUITRIS
33	Şekerbank T.A.Ş.	Büyükdere Caddesi No 171 Metrocity A- Blok Esentepe  Mecidiyeköy İstanbul	212-3197000	212-3197429	http://www.sekerbank.com.tr	46990 skgm- TR eker TR	0059	SEKETR2A
34	Tekstil Bankası A.Ş.	Maslak Mah. Dereboyu/2 Cad. No 13 Sarıyer İstanbul	212-3355335	212-3281328	http://www.tekstilbank.com.tr	39381 tbak TR	0109	TEKBTRIS
35	The Royal Bank of Scotland Plc.	Tamburi Ali Efendi Sok. No 13 Etiler Beşiktaş İstanbul	212-3594040	212-3595050	http://www.rbsbank.com.tr	24677 hbu TR	0088	ABNATRIS
36	Turkish Bank A.Ş.	Vali Konağı Cad. No 1 Nişantaşı Şişli İstanbul	212-3736373	212-225035355	http://www.turkishbank.com.tr	27359 tblı TR	0096	TUBATRIS
37	Turkland Bank A.Ş.	19 Mayıs Mah. 19 Mayıs Cad. Şişli Plaza A Blok No 7 Şişli İstanbul	212-3683434	212-3683535	http://www.tbank.com.tr	25461-25462	0108	TBNKTRIS
38	Türk Ekonomi Bankası A.Ş.	TEB Kampüs C ve D Blok Saray Mah. Sokullu Cad. No. 7A-7B 34768 Ümraniye İstanbul	216-6353535	216-6363636	http://www.teb.com.tr	25358 tebu TR	0032	TEBUTRIS
39	Türk Eximbank	Saray Mahallesi Ahmet Tevfik İleri Cad. No 19 Ümraniye İstanbul	216-6665500	216-6665599	http://www.eximbank.gov.tr	46751 exmb TR	0016	TIKBTR2A
40	Türkiye Cumhuriyeti Ziraat Bankası A.Ş.	Anafartalar Mah. Atatürk Bulvarı No 8 Altındağ Ankara	312-5842000	312-5842551	http://www.ziraatbank.com.tr	44004 zbhm TR	0010	TCZBTR2A
41	Türkiye Garanti Bankası A.Ş.	Nispetiye Mah. Aytar Cad. No 2 Levent Beşiktaş İstanbul	212-3181818	212-3181888	http://www.garanti.com.tr	27635 gatı TR	0062	TGBATRIS
42	Türkiye Halk Bankası A.Ş.	Barbaros Mahallesi, Şebboy Sokak No:4 Ataşehir İstanbul	216-5037070	212-3409399	http://www.halkbank.com.tr	TRHBTR2A	0012	TRHBTR2A
43	Türkiye İş Bankası A.Ş.	Kuleleri Levent Beşiktaş İstanbul	212-3160000	212-3160900-05	http://www.isbank.com.tr	42082 tab TR	0064	ISBKTRIS
44	Türkiye Kalkınma Bankası A.Ş.	Necatibey Caddesi, No 98 Yenişehir Ankara	312-2318400312-2	312-2313125	http://www.kalkinma.com.tr	43206 turb-TR	0017	TKBNTR2A
45	Türkiye Sınai Kalkınma Bankası A.Ş.	Meclisi Mebusan Cad. No 81 Fındıklı İstanbul	212-3345050	212-3345234	http://www.tskb.com.tr	24344 tskb TR	0014	TSKBTRIS
46	Türkiye Vakıflar Bankası T.A.O.	Sanayi Mahallesi Eski Büyükdere Caddesi Güler Sokak No: 51 Kağıthane İstanbul	2123981515-21239	2123981155	http://www.vakifbank.com.tr	46023 vbho-tr	0015	TVBATR2A
47	Yapı ve Kredi Bankası A.Ş.	Yapı Kredi Plaza D Blok Levent İstanbul	212-3397000	212-3396000	http://www.yapikredi.com.tr	931002 ykge TR	0067	YAPITRISFEX
\.


--
-- Data for Name: brands; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.brands (id, brand) FROM stdin;
\.


--
-- Data for Name: campaigns; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.campaigns (id, start_datetime, end_datetime, rate) FROM stdin;
\.


--
-- Data for Name: categories; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.categories (id, title) FROM stdin;
\.


--
-- Data for Name: cities; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.cities (id, name) FROM stdin;
1	Adana
2	Adıyaman
3	Afyonkarahisar
4	Ağrı
5	Amasya
6	Ankara
7	Antalya
8	Artvin
9	Aydın
10	Balıkesir
11	Bilecik
12	Bingöl
13	Bitlis
14	Bolu
15	Burdur
16	Bursa
17	Çanakkale
18	Çankırı
19	Çorum
20	Denizli
21	Diyarbakır
22	Edirne
23	Elazığ
24	Erzincan
25	Erzurum
26	Eskişehir
27	Gaziantep
28	Giresun
29	Gümüşhane
30	Hakkari
31	Hatay
32	Isparta
33	Mersin
34	İstanbul
35	İzmir
36	Kars
37	Kastamonu
38	Kayseri
39	Kırklareli
40	Kırşehir
41	Kocaeli
42	Konya
43	Kütahya
44	Malatya
45	Manisa
46	Kahramanmaraş
47	Mardin
48	Muğla
49	Muş
50	Nevşehir
51	Niğde
52	Ordu
53	Rize
54	Sakarya
55	Samsun
56	Siirt
57	Sinop
58	Sivas
59	Tekirdağ
60	Tokat
61	Trabzon
62	Tunceli
63	Şanlıurfa
64	Uşak
65	Van
66	Yozgat
67	Zonguldak
68	Aksaray
69	Bayburt
70	Karaman
71	Kırıkkale
72	Batman
73	Şırnak
74	Bartın
75	Ardahan
76	Iğdır
77	Yalova
78	Karabük
79	Kilis
80	Osmaniye
81	Düzce
\.


--
-- Data for Name: coupons; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.coupons (id, amount) FROM stdin;
\.


--
-- Data for Name: districts; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.districts (id, name, city_id) FROM stdin;
1	Seyhan	1
2	Ceyhan	1
3	Feke	1
4	Karaisalı	1
5	Karataş	1
6	Kozan	1
7	Pozantı	1
8	Saimbeyli	1
9	Tufanbeyli	1
10	Yumurtalık	1
11	Yüreğir	1
12	Aladağ	1
13	İmamoğlu	1
14	Sarıçam	1
15	Çukurova	1
17	Besni	2
18	Çelikhan	2
19	Gerger	2
21	Kahta	2
22	Samsat	2
23	Sincik	2
24	Tut	2
26	Bolvadin	3
27	Çay	3
28	Dazkırı	3
29	Dinar	3
30	Emirdağ	3
31	İhsaniye	3
32	Sandıklı	3
33	Sinanpaşa	3
34	Sultandağı	3
35	Şuhut	3
36	Başmakçı	3
38	İscehisar	3
39	Çobanlar	3
40	Evciler	3
41	Hocalar	3
42	Kızılören	3
44	Diyadin	4
46	Eleşkirt	4
47	Hamur	4
48	Patnos	4
49	Taşlıçay	4
50	Tutak	4
52	Göynücek	5
53	Gümüşhacıköy	5
54	Merzifon	5
55	Suluova	5
56	Taşova	5
57	Hamamözü	5
58	Altındağ	6
59	Ayaş	6
60	Bala	6
61	Beypazarı	6
62	Çamlıdere	6
63	Çankaya	6
64	Çubuk	6
65	Elmadağ	6
66	Güdül	6
67	Haymana	6
68	Kalecik	6
69	Kızılcahamam	6
70	Nallıhan	6
71	Polatlı	6
72	Şereflikoçhisar	6
73	Yenimahalle	6
75	Keçiören	6
76	Mamak	6
77	Sincan	6
78	Kazan	6
79	Akyurt	6
80	Etimesgut	6
81	Evren	6
82	Pursaklar	6
83	Akseki	7
84	Alanya	7
85	Elmalı	7
86	Finike	7
87	Gazipaşa	7
88	Gündoğmuş	7
89	Kaş	7
90	Korkuteli	7
91	Kumluca	7
92	Manavgat	7
93	Serik	7
94	Demre	7
95	İbradı	7
98	Döşemealtı	7
99	Kepez	7
100	Konyaaltı	7
101	Muratpaşa	7
102	Ardanuç	8
103	Arhavi	8
105	Borçka	8
106	Hopa	8
107	Şavşat	8
108	Yusufeli	8
109	Murgul	8
110	Bozdoğan	9
111	Çine	9
112	Germencik	9
113	Karacasu	9
114	Koçarlı	9
115	Kuşadası	9
116	Kuyucak	9
117	Nazilli	9
118	Söke	9
119	Sultanhisar	9
121	Buharkent	9
122	İncirliova	9
123	Karpuzlu	9
124	Köşk	9
125	Didim	9
126	Efeler	9
127	Ayvalık	10
128	Balya	10
129	Bandırma	10
130	Bigadiç	10
131	Burhaniye	10
132	Dursunbey	10
134	Erdek	10
136	Havran	10
137	İvrindi	10
138	Kepsut	10
139	Manyas	10
140	Savaştepe	10
141	Sındırgı	10
142	Susurluk	10
143	Marmara	10
144	Gömeç	10
145	Altıeylül	10
146	Karesi	10
148	Bozüyük	11
149	Gölpazarı	11
150	Osmaneli	11
151	Pazaryeri	11
152	Söğüt	11
154	İnhisar	11
156	Genç	12
157	Karlıova	12
158	Kiğı	12
159	Solhan	12
160	Adaklı	12
161	Yayladere	12
162	Yedisu	12
163	Adilcevaz	13
164	Ahlat	13
166	Hizan	13
167	Mutki	13
168	Tatvan	13
169	Güroymak	13
171	Gerede	14
172	Göynük	14
173	Kıbrıscık	14
174	Mengen	14
175	Mudurnu	14
176	Seben	14
177	Dörtdivan	14
178	Yeniçağa	14
179	Ağlasun	15
180	Bucak	15
16	Merkez	2
25	Merkez	3
43	Merkez	4
51	Merkez	5
104	Merkez	8
147	Merkez	11
155	Merkez	12
165	Merkez	13
170	Merkez	14
45	Doğubeyazıt	4
182	Gölhisar	15
183	Tefenni	15
184	Yeşilova	15
185	Karamanlı	15
188	Çavdır	15
189	Çeltikçi	15
190	Gemlik	16
191	İnegöl	16
192	İznik	16
193	Karacabey	16
194	Keles	16
195	Mudanya	16
196	Mustafakemalpaşa	16
197	Orhaneli	16
198	Orhangazi	16
200	Büyükorhan	16
201	Harmancık	16
202	Nilüfer	16
203	Osmangazi	16
204	Yıldırım	16
205	Gürsu	16
206	Kestel	16
208	Bayramiç	17
209	Biga	17
210	Bozcaada	17
211	Çan	17
213	Eceabat	17
214	Ezine	17
215	Gelibolu	17
216	Gökçeada	17
217	Lapseki	17
220	Çerkeş	18
221	Eldivan	18
222	Ilgaz	18
223	Kurşunlu	18
224	Orta	18
225	Şabanözü	18
226	Yapraklı	18
227	Atkaracalar	18
228	Kızılırmak	18
229	Bayramören	18
230	Korgun	18
231	Alaca	19
234	İskilip	19
235	Kargı	19
236	Mecitözü	19
238	Osmancık	19
239	Sungurlu	19
240	Boğazkale	19
241	Uğurludağ	19
242	Dodurga	19
243	Laçin	19
244	Oğuzlar	19
245	Acıpayam	20
246	Buldan	20
247	Çal	20
248	Çameli	20
249	Çardak	20
250	Çivril	20
251	Güney	20
253	Sarayköy	20
254	Tavas	20
255	Babadağ	20
256	Bekilli	20
257	Honaz	20
258	Serinhisar	20
259	Pamukkale	20
260	Baklan	20
261	Beyağaç	20
264	Bismil	21
265	Çermik	21
266	Çınar	21
267	Çüngüş	21
268	Dicle	21
269	Ergani	21
270	Hani	21
271	Hazro	21
272	Kulp	21
273	Lice	21
274	Silvan	21
275	Eğil	21
276	Kocaköy	21
277	Bağlar	21
278	Kayapınar	21
279	Sur	21
282	Enez	22
283	Havsa	22
284	İpsala	22
285	Keşan	22
286	Lalapaşa	22
287	Meriç	22
288	Uzunköprü	22
289	Süloğlu	22
290	Ağın	23
291	Baskil	23
293	Karakoçan	23
294	Keban	23
295	Maden	23
296	Palu	23
297	Sivrice	23
298	Arıcak	23
299	Kovancılar	23
300	Alacakaya	23
301	Çayırlı	24
303	İliç	24
304	Kemah	24
305	Kemaliye	24
306	Refahiye	24
307	Tercan	24
308	Üzümlü	24
309	Otlukbeli	24
310	Aşkale	25
311	Çat	25
312	Hınıs	25
313	Horasan	25
314	İspir	25
315	Karayazı	25
316	Narman	25
317	Oltu	25
318	Olur	25
319	Pasinler	25
320	Şenkaya	25
321	Tekman	25
322	Tortum	25
323	Karaçoban	25
324	Uzundere	25
325	Pazaryolu	25
326	Aziziye	25
327	Köprüköy	25
328	Palandöken	25
329	Yakutiye	25
330	Çifteler	26
331	Mahmudiye	26
332	Mihalıççık	26
333	Sarıcakaya	26
334	Seyitgazi	26
335	Sivrihisar	26
336	Alpu	26
337	Beylikova	26
338	İnönü	26
339	Günyüzü	26
340	Han	26
341	Mihalgazi	26
342	Odunpazarı	26
343	Tepebaşı	26
344	Araban	27
345	İslahiye	27
346	Nizip	27
347	Oğuzeli	27
348	Yavuzeli	27
349	Şahinbey	27
350	Şehitkamil	27
351	Karkamış	27
352	Nurdağı	27
353	Alucra	28
354	Bulancak	28
355	Dereli	28
356	Espiye	28
357	Eynesil	28
359	Görele	28
360	Keşap	28
361	Şebinkarahisar	28
181	Merkez	15
212	Merkez	17
219	Merkez	18
233	Merkez	19
263	Merkez	20
281	Merkez	22
292	Merkez	23
302	Merkez	24
358	Merkez	28
362	Tirebolu	28
363	Piraziz	28
364	Yağlıdere	28
365	Çamoluk	28
366	Çanakçı	28
367	Doğankent	28
368	Güce	28
370	Kelkit	29
371	Şiran	29
372	Torul	29
373	Köse	29
374	Kürtün	29
375	Çukurca	30
377	Şemdinli	30
378	Yüksekova	30
379	Altınözü	31
380	Dörtyol	31
381	Hassa	31
382	İskenderun	31
383	Kırıkhan	31
384	Reyhanlı	31
385	Samandağ	31
386	Yayladağı	31
387	Erzin	31
388	Belen	31
389	Kumlu	31
390	Antakya	31
391	Arsuz	31
392	Defne	31
393	Payas	31
394	Atabey	32
395	Eğirdir	32
396	Gelendost	32
398	Keçiborlu	32
399	Senirkent	32
400	Sütçüler	32
401	Şarkikaraağaç	32
402	Uluborlu	32
403	Yalvaç	32
406	Yenişarbademli	32
407	Anamur	33
408	Erdemli	33
409	Gülnar	33
410	Mut	33
411	Silifke	33
412	Tarsus	33
414	Bozyazı	33
415	Çamlıyayla	33
416	Akdeniz	33
417	Mezitli	33
418	Toroslar	33
420	Adalar	34
421	Bakırköy	34
422	Beşiktaş	34
423	Beykoz	34
424	Beyoğlu	34
425	Çatalca	34
426	Eyüp	34
427	Fatih	34
428	Gaziosmanpaşa	34
429	Kadıköy	34
430	Kartal	34
431	Sarıyer	34
432	Silivri	34
433	Şile	34
434	Şişli	34
435	Üsküdar	34
436	Zeytinburnu	34
437	Büyükçekmece	34
438	Kağıthane	34
439	Küçükçekmece	34
440	Pendik	34
441	Ümraniye	34
442	Bayrampaşa	34
443	Avcılar	34
444	Bağcılar	34
445	Bahçelievler	34
446	Güngören	34
447	Maltepe	34
448	Sultanbeyli	34
449	Tuzla	34
450	Esenler	34
451	Arnavutköy	34
452	Ataşehir	34
453	Başakşehir	34
454	Beylikdüzü	34
455	Çekmeköy	34
456	Esenyurt	34
457	Sancaktepe	34
458	Sultangazi	34
459	Aliağa	35
460	Bayındır	35
461	Bergama	35
462	Bornova	35
463	Çeşme	35
464	Dikili	35
465	Foça	35
466	Karaburun	35
467	Karşıyaka	35
469	Kınık	35
470	Kiraz	35
471	Menemen	35
472	Ödemiş	35
473	Seferihisar	35
474	Selçuk	35
475	Tire	35
476	Torbalı	35
477	Urla	35
478	Beydağ	35
479	Buca	35
480	Konak	35
481	Menderes	35
482	Balçova	35
483	Çiğli	35
484	Gaziemir	35
485	Narlıdere	35
486	Güzelbahçe	35
487	Bayraklı	35
488	Karabağlar	35
489	Arpaçay	36
490	Digor	36
491	Kağızman	36
493	Sarıkamış	36
494	Selim	36
495	Susuz	36
496	Akyaka	36
497	Abana	37
498	Araç	37
499	Azdavay	37
501	Cide	37
502	Çatalzeytin	37
503	Daday	37
504	Devrekani	37
505	İnebolu	37
507	Küre	37
508	Taşköprü	37
509	Tosya	37
510	İhsangazi	37
512	Şenpazar	37
513	Ağlı	37
514	Doğanyurt	37
515	Hanönü	37
516	Seydiler	37
517	Bünyan	38
518	Develi	38
519	Felahiye	38
520	İncesu	38
522	Sarıoğlan	38
523	Sarız	38
524	Tomarza	38
525	Yahyalı	38
526	Yeşilhisar	38
527	Akkışla	38
528	Talas	38
529	Kocasinan	38
530	Melikgazi	38
531	Hacılar	38
532	Özvatan	38
533	Babaeski	39
534	Demirköy	39
536	Kofçaz	39
537	Lüleburgaz	39
538	Pehlivanköy	39
539	Pınarhisar	39
540	Vize	39
541	Çiçekdağı	40
369	Merkez	29
376	Merkez	30
397	Merkez	32
492	Merkez	36
506	Merkez	37
535	Merkez	39
542	Kaman	40
544	Mucur	40
545	Akpınar	40
546	Akçakent	40
547	Boztepe	40
548	Gebze	41
549	Gölcük	41
550	Kandıra	41
551	Karamürsel	41
552	Körfez	41
553	Derince	41
554	Başiskele	41
555	Çayırova	41
556	Darıca	41
557	Dilovası	41
558	İzmit	41
559	Kartepe	41
560	Akşehir	42
561	Beyşehir	42
562	Bozkır	42
563	Cihanbeyli	42
564	Çumra	42
565	Doğanhisar	42
567	Hadim	42
568	Ilgın	42
569	Kadınhanı	42
570	Karapınar	42
571	Kulu	42
572	Sarayönü	42
573	Seydişehir	42
574	Yunak	42
575	Akören	42
576	Altınekin	42
577	Derebucak	42
578	Hüyük	42
579	Karatay	42
580	Meram	42
581	Selçuklu	42
582	Taşkent	42
583	Ahırlı	42
584	Çeltik	42
585	Derbent	42
586	Emirgazi	42
587	Güneysınır	42
588	Halkapınar	42
589	Tuzlukçu	42
590	Yalıhüyük	42
591	Altıntaş	43
592	Domaniç	43
593	Emet	43
594	Gediz	43
596	Simav	43
597	Tavşanlı	43
598	Aslanapa	43
599	Dumlupınar	43
600	Hisarcık	43
601	Şaphane	43
602	Çavdarhisar	43
603	Pazarlar	43
604	Akçadağ	44
605	Arapgir	44
606	Arguvan	44
607	Darende	44
608	Doğanşehir	44
609	Hekimhan	44
610	Pütürge	44
612	Battalgazi	44
613	Doğanyol	44
615	Kuluncak	44
616	Yazıhan	44
617	Akhisar	45
618	Alaşehir	45
619	Demirci	45
620	Gördes	45
621	Kırkağaç	45
622	Kula	45
623	Salihli	45
624	Sarıgöl	45
625	Saruhanlı	45
626	Selendi	45
627	Soma	45
628	Turgutlu	45
629	Ahmetli	45
630	Gölmarmara	45
632	Şehzadeler	45
633	Yunusemre	45
634	Afşin	46
635	Andırın	46
636	Elbistan	46
637	Göksun	46
638	Pazarcık	46
639	Türkoğlu	46
640	Çağlayancerit	46
641	Ekinözü	46
642	Nurhak	46
643	Dulkadiroğlu	46
644	Onikişubat	46
645	Derik	47
646	Kızıltepe	47
647	Mazıdağı	47
648	Midyat	47
649	Nusaybin	47
650	Ömerli	47
651	Savur	47
652	Dargeçit	47
653	Yeşilli	47
654	Artuklu	47
655	Bodrum	48
656	Datça	48
657	Fethiye	48
658	Köyceğiz	48
659	Marmaris	48
660	Milas	48
661	Ula	48
662	Yatağan	48
663	Dalaman	48
664	Ortaca	48
665	Kavaklıdere	48
666	Menteşe	48
667	Seydikemer	48
668	Bulanık	49
669	Malazgirt	49
671	Varto	49
672	Hasköy	49
673	Korkut	49
674	Avanos	50
675	Derinkuyu	50
676	Gülşehir	50
677	Hacıbektaş	50
678	Kozaklı	50
680	Ürgüp	50
681	Acıgöl	50
682	Bor	51
683	Çamardı	51
685	Ulukışla	51
686	Altunhisar	51
687	Çiftlik	51
688	Akkuş	52
689	Aybastı	52
690	Fatsa	52
691	Gölköy	52
692	Korgan	52
693	Kumru	52
694	Mesudiye	52
695	Perşembe	52
697	Ünye	52
698	Gülyalı	52
699	Gürgentepe	52
700	Çamaş	52
701	Çatalpınar	52
702	Çaybaşı	52
703	İkizce	52
704	Kabadüz	52
705	Kabataş	52
706	Altınordu	52
707	Ardeşen	53
708	Çamlıhemşin	53
709	Çayeli	53
710	Fındıklı	53
711	İkizdere	53
712	Kalkandere	53
715	Güneysu	53
716	Derepazarı	53
717	Hemşin	53
718	İyidere	53
719	Akyazı	54
720	Geyve	54
721	Hendek	54
722	Karasu	54
723	Kaynarca	54
543	Merkez	40
595	Merkez	43
670	Merkez	49
679	Merkez	50
684	Merkez	51
714	Merkez	53
724	Sapanca	54
725	Kocaali	54
726	Pamukova	54
727	Taraklı	54
728	Ferizli	54
729	Karapürçek	54
730	Söğütlü	54
731	Adapazarı	54
732	Arifiye	54
733	Erenler	54
734	Serdivan	54
735	Alaçam	55
736	Bafra	55
737	Çarşamba	55
738	Havza	55
739	Kavak	55
740	Ladik	55
741	Terme	55
742	Vezirköprü	55
743	Asarcık	55
744	19 Mayıs	55
745	Salıpazarı	55
746	Tekkeköy	55
748	Yakakent	55
749	Atakum	55
750	Canik	55
751	İlkadım	55
752	Baykan	56
753	Eruh	56
754	Kurtalan	56
755	Pervari	56
757	Şirvan	56
758	Tillo	56
759	Ayancık	57
760	Boyabat	57
761	Durağan	57
762	Erfelek	57
763	Gerze	57
765	Türkeli	57
766	Dikmen	57
767	Saraydüzü	57
768	Divriği	58
769	Gemerek	58
770	Gürün	58
771	Hafik	58
772	İmranlı	58
773	Kangal	58
774	Koyulhisar	58
776	Suşehri	58
777	Şarkışla	58
778	Yıldızeli	58
779	Zara	58
780	Akıncılar	58
782	Doğanşar	58
783	Gölova	58
784	Ulaş	58
785	Çerkezköy	59
786	Çorlu	59
787	Hayrabolu	59
788	Malkara	59
789	Muratlı	59
791	Şarköy	59
793	Ergene	59
794	Kapaklı	59
795	Süleymanpaşa	59
796	Almus	60
797	Artova	60
798	Erbaa	60
799	Niksar	60
800	Reşadiye	60
802	Turhal	60
803	Zile	60
806	Başçiftlik	60
807	Sulusaray	60
808	Akçaabat	61
809	Araklı	61
810	Arsin	61
811	Çaykara	61
812	Maçka	61
813	Of	61
814	Sürmene	61
815	Tonya	61
816	Vakfıkebir	61
817	Yomra	61
818	Beşikdüzü	61
819	Şalpazarı	61
820	Çarşıbaşı	61
821	Dernekpazarı	61
822	Düzköy	61
823	Hayrat	61
825	Ortahisar	61
826	Çemişgezek	62
827	Hozat	62
828	Mazgirt	62
829	Nazımiye	62
831	Pertek	62
832	Pülümür	62
834	Akçakale	63
835	Birecik	63
836	Bozova	63
837	Ceylanpınar	63
838	Halfeti	63
839	Hilvan	63
840	Siverek	63
841	Suruç	63
842	Viranşehir	63
843	Harran	63
844	Eyyübiye	63
845	Haliliye	63
846	Karaköprü	63
847	Banaz	64
848	Eşme	64
849	Karahallı	64
850	Sivaslı	64
853	Başkale	65
854	Çatak	65
855	Erciş	65
856	Gevaş	65
857	Gürpınar	65
858	Muradiye	65
859	Özalp	65
860	Bahçesaray	65
861	Çaldıran	65
864	İpekyolu	65
865	Tuşba	65
866	Akdağmadeni	66
867	Boğazlıyan	66
868	Çayıralan	66
869	Çekerek	66
870	Sarıkaya	66
871	Sorgun	66
872	Şefaatli	66
873	Yerköy	66
876	Çandır	66
877	Kadışehri	66
878	Saraykent	66
879	Yenifakılı	66
880	Çaycuma	67
881	Devrek	67
884	Alaplı	67
885	Gökçebey	67
886	Kilimli	67
887	Kozlu	67
890	Ağaçören	68
891	Güzelyurt	68
892	Sarıyahşi	68
893	Eskil	68
894	Gülağaç	68
896	Aydıntepe	69
897	Demirözü	69
898	Ermenek	70
900	Ayrancı	70
756	Merkez	56
764	Merkez	57
775	Merkez	58
801	Merkez	60
833	Merkez	62
852	Merkez	64
874	Merkez	66
883	Merkez	67
888	Merkez	68
895	Merkez	69
899	Merkez	70
901	Kazım Karabekir	70
792	Marmara Ereğlisi	59
902	Başyayla	70
903	Sarıveliler	70
904	Delice	71
905	Keskin	71
907	Sulakyurt	71
908	Bahşili	71
909	Balışeyh	71
910	Çelebi	71
911	Karakeçili	71
912	Yahşihan	71
914	Beşiri	72
915	Gercüş	72
916	Kozluk	72
917	Sason	72
918	Hasankeyf	72
919	Beytüşşebap	73
920	Cizre	73
921	İdil	73
922	Silopi	73
924	Uludere	73
925	Güçlükonak	73
927	Kurucaşile	74
928	Ulus	74
929	Amasra	74
931	Çıldır	75
932	Göle	75
933	Hanak	75
934	Posof	75
935	Damal	75
936	Aralık	76
938	Tuzluca	76
939	Karakoyunlu	76
941	Altınova	77
942	Armutlu	77
943	Çınarcık	77
944	Çiftlikköy	77
945	Termal	77
946	Eflani	78
947	Eskipazar	78
950	Safranbolu	78
953	Elbeyli	79
954	Musabeyli	79
955	Polateli	79
956	Bahçe	80
957	Kadirli	80
959	Düziçi	80
960	Hasanbeyli	80
961	Sumbas	80
962	Toprakkale	80
963	Akçakoca	81
965	Yığılca	81
966	Cumayeri	81
967	Gölyaka	81
968	Çilimli	81
969	Gümüşova	81
970	Kaynaşlı	81
20	Gölbaşı	2
37	Bayat	3
74	Gölbaşı	6
96	Kemer	7
97	Aksu	7
120	Yenipazar	9
133	Edremit	10
135	Gönen	10
153	Yenipazar	11
186	Kemer	15
187	Altınyayla	15
199	Yenişehir	16
207	Ayvacık	17
218	Yenice	17
232	Bayat	19
237	Ortaköy	19
252	Kale	20
262	Bozkurt	20
280	Yenişehir	21
404	Aksu	32
405	Gönen	32
413	Aydıncık	33
419	Yenişehir	33
468	Kemalpaşa	35
500	Bozkurt	37
511	Pınarbaşı	37
521	Pınarbaşı	38
566	Ereğli	42
611	Yeşilyurt	44
614	Kale	44
631	Köprübaşı	45
696	Ulubey	52
713	Pazar	53
747	Ayvacık	55
781	Altınyayla	58
790	Saray	59
804	Pazar	60
805	Yeşilyurt	60
824	Köprübaşı	61
830	Ovacık	62
851	Ulubey	64
862	Edremit	65
863	Saray	65
875	Aydıncık	66
882	Ereğli	67
889	Ortaköy	68
949	Ovacık	78
951	Yenice	78
906	Merkez	71
913	Merkez	72
923	Merkez	73
926	Merkez	74
930	Merkez	75
937	Merkez	76
940	Merkez	77
948	Merkez	78
952	Merkez	79
958	Merkez	80
964	Merkez	81
971	Merkez	1
973	Merkez	55
974	Merkez	7
975	Merkez	9
976	Merkez	38
977	Merkez	6
978	Merkez	10
979	Merkez	16
980	Merkez	21
981	Merkez	25
982	Merkez	27
983	Merkez	59
984	Derecik	30
985	Merkez	31
986	Merkez	35
987	Merkez	33
988	Merkez	34
989	Merkez	61
990	Merkez	63
991	Merkez	65
992	Merkez	41
993	Merkez	47
994	Merkez	48
995	Merkez	52
996	Merkez	54
997	Merkez	45
998	Merkez	46
999	Merkez	26
1000	Merkez	42
1001	Merkez	44
\.


--
-- Data for Name: faq_categories; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.faq_categories (id, title) FROM stdin;
\.


--
-- Data for Name: faq_subcategories; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.faq_subcategories (id, faq_category_id, title) FROM stdin;
\.


--
-- Data for Name: faqs; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.faqs (id, faq_subcategory_id, title, content) FROM stdin;
\.


--
-- Data for Name: general_infos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.general_infos (facebook_address, twitter_address, instagram_address, linkedin_address, pinterest_address, youtube_address, logo_url, whatsapp_number) FROM stdin;
\.


--
-- Data for Name: invoices; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.invoices (id, user_id, invoicee_name, invoicee_surname, invoicee_number, city_id, address, name, type) FROM stdin;
\.


--
-- Data for Name: order_products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.order_products (id, order_id, product_id, count, state) FROM stdin;
\.


--
-- Data for Name: orders; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.orders (id, user_id, claim_address_id, invoice_id, datetime) FROM stdin;
\.


--
-- Data for Name: product_campaigns; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.product_campaigns (id, product_id, campaign_id) FROM stdin;
\.


--
-- Data for Name: product_rates; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.product_rates (id, product_id, user_id, comment, rate, images, hid_user_info_enabled, datetime) FROM stdin;
\.


--
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.products (id, barcode, subsubcategory_id, brand_id, name, vat_rate, expiry, commission, warranty_period, warranty_type, description, properties, cargo_corporation, deci) FROM stdin;
\.


--
-- Data for Name: shop_products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.shop_products (id, shop_id, product_id, variant_group_id, product_rating, rating_count, stock_amount, stock_code, price, day_for_cargo, images, release_datetime, state) FROM stdin;
\.


--
-- Data for Name: shops; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.shops (id, username, password, shop_owner_name, authorized_name, authorized_surname, authorized_gender, authorized_position, authorized_phone, authorized_email, firm_owner_name, firm_owner_surname, firm_owner_phone, kep_mail, firm_website, firm_email, legal_firm_name, firm_type, firm_profile, selling_subcategory_id, commercial_record_number, tax_office_city_id, tax_office_id, tax_or_trid_number, mersis_number, firm_fixed_phone, invoice_address, invoice_city_id, invoice_district_id, invoice_email, bank_account_owner, bank_id, branch_bank_name, branch_code, account_number, iban) FROM stdin;
\.


--
-- Data for Name: slides; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.slides (id, image_url, route_url, slide_order) FROM stdin;
\.


--
-- Data for Name: subcategories; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.subcategories (id, category_id, title) FROM stdin;
\.


--
-- Data for Name: subsubcategories; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.subsubcategories (id, subcategory_id, title) FROM stdin;
\.


--
-- Data for Name: tax_offices; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tax_offices (id, city_id, district_id, accounting_unit_code, name) FROM stdin;
6552	20	252	20108	Kale Malmüdürlüğü
6273	1	4	1105	Karaisalı Malmüdürlüğü
6274	1	7	1109	Pozantı Malmüdürlüğü
6275	1	971	1255	Çukurova Vergi Dairesi Müdürlüğü
6276	1	8	1110	Saimbeyli Malmüdürlüğü
6277	1	9	1111	Tufanbeyli Malmüdürlüğü
6278	1	10	1112	Yumurtalık Malmüdürlüğü
6279	1	12	1114	Aladağ Malmüdürlüğü
6280	1	13	1115	İmamoğlu Malmüdürlüğü
6281	1	971	1250	Adana İhtisas Vergi Dairesi Müdürlüğü
6282	1	971	1252	Yüreğir Vergi Dairesi Müdürlüğü
6283	1	971	1254	Ziyapaşa Vergi Dairesi Müdürlüğü
6284	1	6	1203	Kozan Vergi Dairesi Müdürlüğü
6285	1	971	1251	5 Ocak Vergi Dairesi Müdürlüğü
6286	1	2	1201	Ceyhan Vergi Dairesi Müdürlüğü
6287	1	971	1253	Seyhan Vergi Dairesi Müdürlüğü
6288	1	5	1205	Karataş Vergi Dairesi Müdürlüğü
6289	1	3	1103	Feke Malmüdürlüğü
6290	2	18	2102	Çelikhan Malmüdürlüğü
6291	2	19	2103	Gerger Malmüdürlüğü
6292	2	20	2104	Gölbaşı Malmüdürlüğü
6293	2	22	2106	Samsat Malmüdürlüğü
6294	2	23	2107	Sincik Malmüdürlüğü
6295	2	16	2260	Adıyaman Vergi Dairesi Müdürlüğü
6296	2	21	2261	Kahta Vergi Dairesi Müdürlüğü
6297	2	17	2101	Besni Malmüdürlüğü
6298	2	24	2108	Tut Malmüdürlüğü
6299	3	34	3108	Sultandağı Malmüdürlüğü
6300	3	25	3201	Tınaztepe Vergi Dairesi Müdürlüğü
6301	3	25	3280	Kocatepe Vergi Dairesi Müdürlüğü
6302	3	29	3260	Dinar Vergi Dairesi Müdürlüğü
6303	3	26	3261	Bolvadin Vergi Dairesi Müdürlüğü
6304	3	30	3262	Emirdağ Vergi Dairesi Müdürlüğü
6305	3	32	3263	Sandıklı Vergi Dairesi Müdürlüğü
6306	3	38	3264	İscehisar Vergi Dairesi Müdürlüğü
6307	3	27	3202	Çay Vergi Dairesi Müdürlüğü
6308	3	28	3103	Dazkırı Malmüdürlüğü
6309	3	31	3105	İhsaniye Malmüdürlüğü
6310	3	33	3107	Sinanpaşa Malmüdürlüğü
6311	3	35	3109	Şuhut Malmüdürlüğü
6312	3	36	3111	Başmakçı Malmüdürlüğü
6313	3	37	3112	Bayat Malmüdürlüğü
6314	3	39	3114	Çobanlar Malmüdürlüğü
6315	3	40	3115	Evciler Malmüdürlüğü
6316	3	41	3116	Hocalar Malmüdürlüğü
6317	3	42	3117	Kızılören Malmüdürlüğü
6318	4	43	4260	Ağrı Vergi Dairesi Müdürlüğü
6319	4	45	4261	Doğubeyazıt Vergi Dairesi Müdürlüğü
6320	4	48	4262	Patnos Vergi Dairesi Müdürlüğü
6321	4	44	4101	Diyadin Malmüdürlüğü
6322	4	46	4103	Eleşkirt Malmüdürlüğü
6323	4	47	4104	Hamur Malmüdürlüğü
6324	4	49	4106	Taşlıçay Malmüdürlüğü
6325	4	50	4107	Tutak Malmüdürlüğü
6326	5	51	5260	Amasya Vergi Dairesi Müdürlüğü
6327	5	54	5261	Merzifon Vergi Dairesi Müdürlüğü
6328	5	53	5262	Gümüşhacıköy Vergi Dairesi Müdürlüğü
6329	5	56	5263	Taşova Vergi Dairesi Müdürlüğü
6330	5	55	5264	Suluova Vergi Dairesi Müdürlüğü
6331	5	52	5101	Göynücek Malmüdürlüğü
6332	5	57	5106	Hamamözü Malmüdürlüğü
6333	6	977	6269	Yahya Galip Vergi Dairesi Müdürlüğü
6334	6	977	6280	Anadolu İhtisas Vergi Dairesi Müdürlüğü
6335	6	977	6281	Ankara İhtisas Vergi Dairesi Müdürlüğü
6336	6	977	6252	Veraset ve Harçlar Vergi Dairesi Müdürlüğü
6337	6	977	6253	Kavaklıdere Vergi Dairesi Müdürlüğü
6338	6	977	6254	Maltepe Vergi Dairesi Müdürlüğü
6339	6	977	6255	Yenimahalle Vergi Dairesi Müdürlüğü
6340	6	977	6257	Çankaya Vergi Dairesi Müdürlüğü
6341	6	977	6258	Kızılbey Vergi Dairesi Müdürlüğü
6342	6	977	6259	Mithatpaşa Vergi Dairesi Müdürlüğü
6343	6	977	6260	Ulus Vergi Dairesi Müdürlüğü
6344	6	977	6261	Yıldırım Beyazıt Vergi Dairesi Müdürlüğü
6345	6	977	6262	Seğmenler Vergi Dairesi Müdürlüğü
6346	6	977	6264	Dikimevi Vergi Dairesi Müdürlüğü
6347	6	977	6265	Doğanbey Vergi Dairesi Müdürlüğü
6348	6	977	6266	Yeğenbey Vergi Dairesi Müdürlüğü
6349	6	977	6268	Hitit Vergi Dairesi Müdürlüğü
6350	6	977	6270	Muhammet Karagüzel Vergi Dairesi Müdürlüğü
6351	6	977	6271	Ostim Vergi Dairesi Müdürlüğü
6352	6	977	6272	Gölbaşı Vergi Dairesi Müdürlüğü
6353	6	977	6273	Sincan Vergi Dairesi Müdürlüğü
6354	6	977	6274	Dışkapı Vergi Dairesi Müdürlüğü
6355	6	977	6275	Etimesgut Vergi Dairesi Müdürlüğü
6356	6	977	6276	Başkent Vergi Dairesi Müdürlüğü
6357	6	977	6277	Cumhuriyet Vergi Dairesi Müdürlüğü
6358	6	977	6278	Keçiören Vergi Dairesi Müdürlüğü
6359	6	977	6279	Kahramankazan Vergi Dairesi Müdürlüğü
6360	6	71	6205	Polatlı Vergi Dairesi Müdürlüğü
6361	6	72	6207	Şereflikoçhisar Vergi Dairesi Müdürlüğü
6362	6	61	6209	Beypazarı Vergi Dairesi Müdürlüğü
6363	6	977	6211	Çubuk Vergi Dairesi Müdürlüğü
6364	6	67	6213	Haymana Vergi Dairesi Müdürlüğü
6365	6	977	6215	Elmadağ Vergi Dairesi Müdürlüğü
6366	6	977	6102	Ayaş Malmüdürlüğü
6367	6	977	6103	Balâ Malmüdürlüğü
6368	6	62	6106	Çamlıdere Malmüdürlüğü
6369	6	66	6110	Güdül Malmüdürlüğü
6370	6	977	6112	Kalecik Malmüdürlüğü
6371	6	69	6115	Kızılcahamam Malmüdürlüğü
6372	6	70	6117	Nallıhan Malmüdürlüğü
6373	6	977	6125	Akyurt Malmüdürlüğü
6374	6	81	6127	Evren Malmüdürlüğü
6375	7	974	7251	Üçkapılar Vergi Dairesi Müdürlüğü
6376	7	974	7252	Kalekapı Vergi Dairesi Müdürlüğü
6377	7	974	7253	Muratpaşa Vergi Dairesi Müdürlüğü
6378	7	974	7254	Düden Vergi Dairesi Müdürlüğü
6379	7	974	7255	Antalya Kurumlar Vergi Dairesi Müdürlüğü
6380	7	974	7256	Antalya İhtisas Vergi Dairesi Müdürlüğü
6381	7	90	7257	Korkuteli Vergi Dairesi Müdürlüğü
6382	7	84	7201	Alanya Vergi Dairesi Müdürlüğü
6383	7	93	7202	Serik Vergi Dairesi Müdürlüğü
6384	7	92	7203	Manavgat Vergi Dairesi Müdürlüğü
6385	7	85	7204	Elmalı Vergi Dairesi Müdürlüğü
6386	7	96	7205	Kemer Vergi Dairesi Müdürlüğü
6387	7	91	7206	Kumluca Vergi Dairesi Müdürlüğü
6388	7	83	7101	Akseki Malmüdürlüğü
6389	7	86	7104	Finike Malmüdürlüğü
6390	7	87	7105	Gazipaşa Malmüdürlüğü
6391	7	88	7106	Gündoğmuş Malmüdürlüğü
6392	7	89	7107	Kaş Malmüdürlüğü
6393	7	94	7112	Demre Malmüdürlüğü
6394	7	95	7113	İbradı Malmüdürlüğü
6395	8	109	8107	Murgul Malmüdürlüğü
6396	8	104	8260	Artvin Vergi Dairesi Müdürlüğü
6397	8	106	8261	Hopa Vergi Dairesi Müdürlüğü
6398	8	103	8262	Arhavi Vergi Dairesi Müdürlüğü
6399	8	102	8101	Ardanuç Malmüdürlüğü
6400	8	105	8103	Borçka Malmüdürlüğü
6401	8	107	8105	Şavşat Malmüdürlüğü
6402	8	108	8106	Yusufeli Malmüdürlüğü
6403	9	975	9201	Efeler Vergi Dairesi Müdürlüğü
6404	9	112	9263	Germencik Vergi Dairesi Müdürlüğü
6405	9	115	9265	Kuşadası Vergi Dairesi Müdürlüğü
6406	9	125	9281	Didim Vergi Dairesi Müdürlüğü
6407	9	110	9101	Bozdoğan Malmüdürlüğü
6408	9	975	9280	Güzelhisar Vergi Dairesi Müdürlüğü
6409	9	113	9104	Karacasu Malmüdürlüğü
6410	9	114	9105	Koçarlı Malmüdürlüğü
6411	9	116	9107	Kuyucak Malmüdürlüğü
6412	9	119	9110	Sultanhisar Malmüdürlüğü
6413	9	120	9111	Yenipazar Malmüdürlüğü
6414	9	121	9112	Buharkent Malmüdürlüğü
6415	9	122	9113	İncirliova Malmüdürlüğü
6416	9	123	9114	Karpuzlu Malmüdürlüğü
6417	9	124	9115	Köşk Malmüdürlüğü
6418	9	118	9261	Söke Vergi Dairesi Müdürlüğü
6419	9	111	9262	Çine Vergi Dairesi Müdürlüğü
6420	9	117	9260	Nazilli Vergi Dairesi Müdürlüğü
6421	10	140	10114	Savaştepe Malmüdürlüğü
6422	10	143	10117	Marmara Malmüdürlüğü
6423	10	144	10118	Gömeç Malmüdürlüğü
6424	10	978	10201	Karesi Vergi Dairesi Müdürlüğü
6425	10	978	10280	Kurtdereli Vergi Dairesi Müdürlüğü
6426	10	127	10260	Ayvalık Vergi Dairesi Müdürlüğü
6427	10	129	10261	Bandırma Vergi Dairesi Müdürlüğü
6428	10	131	10262	Burhaniye Vergi Dairesi Müdürlüğü
6429	10	133	10263	Edremit Vergi Dairesi Müdürlüğü
6430	10	135	10264	Gönen Vergi Dairesi Müdürlüğü
6431	10	142	10265	Susurluk Vergi Dairesi Müdürlüğü
6432	10	134	10266	Erdek Vergi Dairesi Müdürlüğü
6433	10	130	10267	Bigadiç Vergi Dairesi Müdürlüğü
6434	10	141	10268	Sındırgı Vergi Dairesi Müdürlüğü
6435	10	132	10269	Dursunbey Vergi Dairesi Müdürlüğü
6436	10	128	10102	Balya Malmüdürlüğü
6437	10	136	10110	Havran Malmüdürlüğü
6438	10	137	10111	İvrindi Malmüdürlüğü
6439	10	138	10112	Kepsut Malmüdürlüğü
6440	10	139	10113	Manyas Malmüdürlüğü
6441	11	147	11260	Bilecik Vergi Dairesi Müdürlüğü
6442	11	148	11261	Bozüyük Vergi Dairesi Müdürlüğü
6443	11	149	11102	Gölpazarı Malmüdürlüğü
6444	11	150	11103	Osmaneli Malmüdürlüğü
6445	11	151	11104	Pazaryeri Malmüdürlüğü
6446	11	152	11105	Söğüt Malmüdürlüğü
6447	11	153	11106	Yenipazar Malmüdürlüğü
6448	11	154	11107	İnhisar Malmüdürlüğü
6449	12	155	12260	Bingöl Vergi Dairesi Müdürlüğü
6450	12	156	12101	Genç Malmüdürlüğü
6451	12	157	12102	Karlıova Malmüdürlüğü
6452	12	158	12103	Kiğı Malmüdürlüğü
6453	12	159	12104	Solhan Malmüdürlüğü
6454	12	160	12105	Adaklı Malmüdürlüğü
6455	12	161	12106	Yayladere Malmüdürlüğü
6456	12	162	12107	Yedisu Malmüdürlüğü
6457	13	165	13260	Bitlis Vergi Dairesi Müdürlüğü
6458	13	168	13261	Tatvan Vergi Dairesi Müdürlüğü
6459	13	163	13101	Adilcevaz Malmüdürlüğü
6460	13	164	13102	Ahlat Malmüdürlüğü
6461	13	166	13103	Hizan Malmüdürlüğü
6462	13	167	13104	Mutki Malmüdürlüğü
6463	13	169	13106	Güroymak Malmüdürlüğü
6464	14	174	14106	Mengen Malmüdürlüğü
6465	14	170	14260	Bolu Vergi Dairesi Müdürlüğü
6466	14	171	14262	Gerede Vergi Dairesi Müdürlüğü
6467	14	172	14104	Göynük Malmüdürlüğü
6468	14	173	14105	Kıbrıscık Malmüdürlüğü
6469	14	175	14107	Mudurnu Malmüdürlüğü
6470	14	176	14108	Seben Malmüdürlüğü
6471	14	177	14113	Dörtdivan Malmüdürlüğü
6472	14	178	14114	Yeniçağa Malmüdürlüğü
6473	15	184	15105	Yeşilova Malmüdürlüğü
6474	15	185	15106	Karamanlı Malmüdürlüğü
6475	15	186	15107	Kemer Malmüdürlüğü
6476	15	187	15108	Altınyayla Malmüdürlüğü
6477	15	188	15109	Çavdır Malmüdürlüğü
6478	15	189	15110	Çeltikçi Malmüdürlüğü
6479	15	179	15101	Ağlasun Malmüdürlüğü
6480	15	182	15103	Gölhisar Malmüdürlüğü
6481	15	183	15104	Tefenni Malmüdürlüğü
6482	15	180	15261	Bucak Vergi Dairesi Müdürlüğü
6483	15	181	15260	Burdur Vergi Dairesi Müdürlüğü
6484	16	979	16260	Bursa Veraset ve Harçlar Vergi Dairesi Müdürlüğü
6485	16	979	16201	Gemlik Vergi Dairesi Müdürlüğü
6486	16	193	16203	Karacabey Vergi Dairesi Müdürlüğü
6487	16	196	16204	Mustafakemalpaşa Vergi Dairesi Müdürlüğü
6488	16	979	16205	Mudanya Vergi Dairesi Müdürlüğü
6489	16	198	16206	Orhangazi Vergi Dairesi Müdürlüğü
6490	16	192	16207	İznik Vergi Dairesi Müdürlüğü
6491	16	199	16208	Yenişehir Vergi Dairesi Müdürlüğü
6492	16	194	16105	Keles Malmüdürlüğü
6493	16	197	16108	Orhaneli Malmüdürlüğü
6494	16	201	16111	Harmancık Malmüdürlüğü
6495	16	200	16112	Büyükorhan Malmüdürlüğü
6496	16	191	16202	İnegöl Vergi Dairesi Müdürlüğü
6497	16	979	16250	Bursa İhtisas Vergi Dairesi Müdürlüğü
6498	16	979	16251	Osmangazi Vergi Dairesi Müdürlüğü
6499	16	979	16252	Yıldırım Vergi Dairesi Müdürlüğü
6500	16	979	16253	Çekirge Vergi Dairesi Müdürlüğü
6501	16	979	16254	Setbaşı Vergi Dairesi Müdürlüğü
6502	16	979	16255	Uludağ Vergi Dairesi Müdürlüğü
6503	16	979	16256	Yeşil Vergi Dairesi Müdürlüğü
6504	16	979	16257	Nilüfer Vergi Dairesi Müdürlüğü
6505	16	979	16258	Ertuğrulgazi Vergi Dairesi Müdürlüğü
6506	16	979	16259	Gökdere Vergi Dairesi Müdürlüğü
6507	17	209	17261	Biga Vergi Dairesi Müdürlüğü
6508	17	211	17262	Çan Vergi Dairesi Müdürlüğü
6509	17	215	17263	Gelibolu Vergi Dairesi Müdürlüğü
6510	17	207	17101	Ayvacık Malmüdürlüğü
6511	17	208	17102	Bayramiç Malmüdürlüğü
6512	17	210	17104	Bozcaada Malmüdürlüğü
6513	17	213	17106	Eceabat Malmüdürlüğü
6514	17	214	17107	Ezine Malmüdürlüğü
6515	17	216	17109	Gökçeada Malmüdürlüğü
6516	17	217	17110	Lapseki Malmüdürlüğü
6517	17	218	17111	Yenice Malmüdürlüğü
6518	17	212	17260	Çanakkale Vergi Dairesi Müdürlüğü
6519	18	220	18101	Çerkeş Malmüdürlüğü
6520	18	221	18102	Eldivan Malmüdürlüğü
6521	18	222	18104	Ilgaz Malmüdürlüğü
6522	18	223	18105	Kurşunlu Malmüdürlüğü
6523	18	224	18106	Orta Malmüdürlüğü
6524	18	225	18108	Şabanözü Malmüdürlüğü
6525	18	226	18109	Yapraklı Malmüdürlüğü
6526	18	227	18110	Atkaracalar Malmüdürlüğü
6527	18	228	18111	Kızılırmak Malmüdürlüğü
6528	18	229	18112	Bayramören Malmüdürlüğü
6529	18	230	18113	Korgun Malmüdürlüğü
6530	18	219	18260	Çankırı Vergi Dairesi Müdürlüğü
6531	19	234	19103	İskilip Malmüdürlüğü
6532	19	233	19260	Çorum Vergi Dairesi Müdürlüğü
6533	19	239	19261	Sungurlu Vergi Dairesi Müdürlüğü
6534	19	231	19101	Alaca Malmüdürlüğü
6535	19	232	19102	Bayat Malmüdürlüğü
6536	19	235	19104	Kargı Malmüdürlüğü
6537	19	236	19105	Mecitözü Malmüdürlüğü
6538	19	237	19106	Ortaköy Malmüdürlüğü
6539	19	238	19107	Osmancık Malmüdürlüğü
6540	19	240	19109	Boğazkale Malmüdürlüğü
6541	19	241	19110	Uğurludağ Malmüdürlüğü
6542	19	242	19111	Dodurga Malmüdürlüğü
6543	19	244	19112	Oğuzlar Malmüdürlüğü
6544	19	243	19113	Laçin Malmüdürlüğü
6545	20	246	20263	Buldan Vergi Dairesi Müdürlüğü
6546	20	247	20264	Çal Vergi Dairesi Müdürlüğü
6547	20	250	20265	Çivril Vergi Dairesi Müdürlüğü
6548	20	248	20104	Çameli Malmüdürlüğü
6549	20	249	20105	Çardak Malmüdürlüğü
6550	20	251	20107	Güney Malmüdürlüğü
6551	20	263	20280	Pamukkale Vergi Dairesi Müdürlüğü
6553	20	263	20202	Çınar Vergi Dairesi Müdürlüğü
6554	20	263	20203	Gökpınar Vergi Dairesi Müdürlüğü
6555	20	255	20111	Babadağ Malmüdürlüğü
6556	20	256	20112	Bekilli Malmüdürlüğü
6557	20	263	20250	Denizli İhtisas Vergi Dairesi Müdürlüğü
6558	20	245	20261	Acıpayam Vergi Dairesi Müdürlüğü
6559	20	263	20201	Saraylar Vergi Dairesi Müdürlüğü
6560	20	253	20260	Sarayköy Vergi Dairesi Müdürlüğü
6561	20	257	20113	Honaz Malmüdürlüğü
6562	20	258	20114	Serinhisar Malmüdürlüğü
6563	20	259	20115	Pamukkale Malmüdürlüğü Akköy)
6564	20	260	20116	Baklan Malmüdürlüğü
6565	20	261	20117	Beyağaç Malmüdürlüğü
6566	20	262	20118	Bozkurt Malmüdürlüğü
6567	20	254	20262	Tavas Vergi Dairesi Müdürlüğü
6568	21	275	21112	Eğil Malmüdürlüğü
6569	21	980	21251	Gökalp Vergi Dairesi Müdürlüğü
6570	21	980	21281	Süleyman Nazif Vergi Dairesi Müdürlüğü
6571	21	980	21282	Cahit Sıtkı Tarancı Vergi Dairesi Müdürlüğü
6572	21	269	21283	Ergani Vergi Dairesi Müdürlüğü
6573	21	264	21284	Bismil Vergi Dairesi Müdürlüğü
6574	21	265	21102	Çermik Malmüdürlüğü
6575	21	266	21103	Çınar Malmüdürlüğü
6576	21	267	21104	Çüngüş Malmüdürlüğü
6577	21	268	21105	Dicle Malmüdürlüğü
6578	21	270	21107	Hani Malmüdürlüğü
6579	21	271	21108	Hazro Malmüdürlüğü
6580	21	272	21109	Kulp Malmüdürlüğü
6581	21	273	21110	Lice Malmüdürlüğü
6582	21	274	21111	Silvan Malmüdürlüğü
6583	21	276	21113	Kocaköy Malmüdürlüğü
6584	22	281	22260	Kırkpınar Vergi Dairesi Müdürlüğü
6585	22	285	22261	Keşan Vergi Dairesi Müdürlüğü
6586	22	288	22262	Uzunköprü Vergi Dairesi Müdürlüğü
6587	22	283	22263	Havsa Vergi Dairesi Müdürlüğü
6588	22	284	22264	İpsala Vergi Dairesi Müdürlüğü
6589	22	282	22101	Enez Malmüdürlüğü
6590	22	286	22105	Lalapaşa Malmüdürlüğü
6591	22	287	22106	Meriç Malmüdürlüğü
6592	22	289	22108	Süloğlu Malmüdürlüğü
6593	22	281	22201	Arda Vergi Dairesi Müdürlüğü
6594	23	298	23108	Arıcak Malmüdürlüğü
6595	23	292	23201	Harput Vergi Dairesi Müdürlüğü
6596	23	292	23280	Hazar Vergi Dairesi Müdürlüğü
6597	23	290	23101	Ağın Malmüdürlüğü
6598	23	291	23102	Baskil Malmüdürlüğü
6599	23	293	23103	Karakoçan Malmüdürlüğü
6600	23	294	23104	Keban Malmüdürlüğü
6601	23	295	23105	Maden Malmüdürlüğü
6602	23	296	23106	Palu Malmüdürlüğü
6603	23	297	23107	Sivrice Malmüdürlüğü
6604	23	299	23109	Kovancılar Malmüdürlüğü
6605	23	300	23110	Alacakaya Malmüdürlüğü
6606	24	301	24101	Çayırlı Malmüdürlüğü
6607	24	308	24107	Üzümlü Malmüdürlüğü
6608	24	309	24108	Otlukbeli Malmüdürlüğü
6609	24	303	24102	İliç Malmüdürlüğü
6610	24	304	24103	Kemah Malmüdürlüğü
6611	24	305	24104	Kemaliye Malmüdürlüğü
6612	24	306	24105	Refahiye Malmüdürlüğü
6613	24	307	24106	Tercan Malmüdürlüğü
6614	24	302	24260	Fevzipaşa Vergi Dairesi Müdürlüğü
6615	25	316	25107	Narman Malmüdürlüğü
6616	25	317	25108	Oltu Malmüdürlüğü
6617	25	318	25109	Olur Malmüdürlüğü
6618	25	319	25110	Pasinler Malmüdürlüğü
6619	25	321	25112	Tekman Malmüdürlüğü
6620	25	322	25113	Tortum Malmüdürlüğü
6621	25	323	25114	Karaçoban Malmüdürlüğü
6622	25	324	25115	Uzundere Malmüdürlüğü
6623	25	325	25116	Pazaryolu Malmüdürlüğü
6624	25	981	25117	Aziziye Malmüdürlüğü Ilıca)
6625	25	327	25118	Köprüköy Malmüdürlüğü
6626	25	320	25111	Şenkaya Malmüdürlüğü
6627	25	981	25251	Aziziye Vergi Dairesi Müdürlüğü
6628	25	981	25280	Kazımkarabekir Vergi Dairesi Müdürlüğü
6629	25	310	25101	Aşkale Malmüdürlüğü
6630	25	311	25102	Çat Malmüdürlüğü
6631	25	312	25103	Hınıs Malmüdürlüğü
6632	25	313	25104	Horasan Malmüdürlüğü
6633	25	314	25105	İspir Malmüdürlüğü
6634	25	315	25106	Karayazı Malmüdürlüğü
6635	26	332	26103	Mihalıççık Malmüdürlüğü
6636	26	333	26104	Sarıcakaya Malmüdürlüğü
6637	26	334	26105	Seyitgazi Malmüdürlüğü
6638	26	336	26107	Alpu Malmüdürlüğü
6639	26	337	26108	Beylikova Malmüdürlüğü
6640	26	338	26109	İnönü Malmüdürlüğü
6641	26	339	26110	Günyüzü Malmüdürlüğü
6642	26	340	26111	Han Malmüdürlüğü
6643	26	341	26112	Mihalgazi Malmüdürlüğü
6644	26	331	26102	Mahmudiye Malmüdürlüğü
6645	26	999	26250	Eskişehir Vergi Dairesi Başkanlığı
6646	27	982	27252	Şehitkâmil Vergi Dairesi Müdürlüğü
6647	27	982	27253	Şahinbey Vergi Dairesi Müdürlüğü
6648	27	982	27254	Gazikent Vergi Dairesi Müdürlüğü
6649	27	982	27255	Kozanlı Vergi Dairesi Müdürlüğü
6650	27	346	27202	Nizip Vergi Dairesi Müdürlüğü
6651	27	345	27203	İslahiye Vergi Dairesi Müdürlüğü
6652	27	344	27101	Araban Malmüdürlüğü
6653	27	982	27105	Oğuzeli Malmüdürlüğü
6654	27	348	27106	Yavuzeli Malmüdürlüğü
6655	27	351	27107	Karkamış Malmüdürlüğü
6656	27	352	27108	Nurdağı Malmüdürlüğü
6657	27	982	27250	Gaziantep İhtisas Vergi Dairesi Müdürlüğü
6658	27	982	27251	Suburcu Vergi Dairesi Müdürlüğü
6659	28	368	28113	Güce Malmüdürlüğü
6660	28	358	28260	Giresun Vergi Dairesi Müdürlüğü
6661	28	354	28261	Bulancak Vergi Dairesi Müdürlüğü
6662	28	353	28101	Alucra Malmüdürlüğü
6663	28	355	28103	Dereli Malmüdürlüğü
6664	28	356	28104	Espiye Malmüdürlüğü
6665	28	357	28105	Eynesil Malmüdürlüğü
6666	28	359	28106	Görele Malmüdürlüğü
6667	28	360	28107	Keşap Malmüdürlüğü
6668	28	361	28108	Şebinkarahisar Malmüdürlüğü
6669	28	362	28109	Tirebolu Malmüdürlüğü
6670	28	363	28110	Piraziz Malmüdürlüğü
6671	28	364	28111	Yağlıdere Malmüdürlüğü
6672	28	366	28112	Çanakçı Malmüdürlüğü
6673	28	365	28114	Çamoluk Malmüdürlüğü
6674	28	367	28115	Doğankent Malmüdürlüğü
6675	29	371	29103	Şiran Malmüdürlüğü
6676	29	369	29260	Gümüşhane Vergi Dairesi Müdürlüğü
6677	29	370	29102	Kelkit Malmüdürlüğü
6678	29	374	29108	Kürtün Malmüdürlüğü
6679	29	373	29107	Köse Malmüdürlüğü
6680	29	372	29104	Torul Malmüdürlüğü
6681	30	378	30261	Yüksekova Vergi Dairesi Müdürlüğü
6682	30	376	30260	Hakkari Vergi Dairesi Müdürlüğü
6683	30	984	30104	Derecik Malmüdürlüğü
6684	30	377	30103	Şemdinli Malmüdürlüğü
6685	30	375	30102	Çukurca Malmüdürlüğü
6686	31	387	31109	Erzin Malmüdürlüğü
6687	31	388	31110	Belen Malmüdürlüğü
6688	31	389	31111	Kumlu Malmüdürlüğü
6689	31	985	31280	Şükrükanatlı Vergi Dairesi Müdürlüğü
6690	31	382	31202	Sahil Vergi Dairesi Müdürlüğü
6691	31	382	31281	Akdeniz Vergi Dairesi Müdürlüğü
6692	31	382	31290	Asım Gündüz Vergi Dairesi Müdürlüğü
6693	31	380	31260	Dörtyol Vergi Dairesi Müdürlüğü
6694	31	383	31261	Kırıkhan Vergi Dairesi Müdürlüğü
6695	31	384	31262	Reyhanlı Vergi Dairesi Müdürlüğü
6696	31	385	31263	Samandağ Vergi Dairesi Müdürlüğü
6697	31	379	31101	Altınözü Malmüdürlüğü
6698	31	381	31103	Hassa Malmüdürlüğü
6699	31	386	31108	Yayladağı Malmüdürlüğü
6700	31	985	31201	23 Temmuz Vergi Dairesi Müdürlüğü
6701	31	985	31203	Antakya Vergi Dairesi Müdürlüğü
6702	32	406	32112	Yenişarbademli Malmüdürlüğü
6703	32	402	32108	Uluborlu Malmüdürlüğü
6704	32	401	32107	Şarkikaraağaç Malmüdürlüğü
6705	32	400	32106	Sütçüler Malmüdürlüğü
6706	32	399	32105	Senirkent Malmüdürlüğü
6707	32	398	32104	Keçiborlu Malmüdürlüğü
6708	32	396	32103	Gelendost Malmüdürlüğü
6709	32	394	32101	Atabey Malmüdürlüğü
6710	32	403	32262	Yalvaç Vergi Dairesi Müdürlüğü
6711	32	397	32260	Kaymakkapı Vergi Dairesi Müdürlüğü
6712	32	397	32201	Davraz Vergi Dairesi Müdürlüğü
6713	32	395	32261	Eğirdir Vergi Dairesi Müdürlüğü
6714	32	404	32110	Aksu Malmüdürlüğü
6715	32	405	32111	Gönen Malmüdürlüğü
6716	33	414	33108	Bozyazı Malmüdürlüğü
6717	33	415	33109	Çamlıyayla Malmüdürlüğü
6718	33	987	33250	İstiklâl Vergi Dairesi Müdürlüğü
6719	33	987	33252	Uray Vergi Dairesi Müdürlüğü
6720	33	987	33254	Liman Vergi Dairesi Müdürlüğü
6721	33	987	33255	Toros Vergi Dairesi Müdürlüğü
6722	33	987	33256	Mersin İhtisas Vergi Dairesi Müdürlüğü
6723	33	408	33201	Erdemli Vergi Dairesi Müdürlüğü
6724	33	411	33202	Silifke Vergi Dairesi Müdürlüğü
6725	33	407	33203	Anamur Vergi Dairesi Müdürlüğü
6726	33	412	33204	Kızılmurat Vergi Dairesi Müdürlüğü
6727	33	412	33205	Şehitkerim Vergi Dairesi Müdürlüğü
6728	33	409	33103	Gülnar Malmüdürlüğü
6729	33	410	33104	Mut Malmüdürlüğü
6730	33	413	33107	Aydıncık Malmüdürlüğü
6731	34	988	34294	Avcılar Vergi Dairesi Müdürlüğü
6732	34	988	34295	Adalar Vergi Dairesi Müdürlüğü
6733	34	988	34296	Küçükçekmece Vergi Dairesi Müdürlüğü
6734	34	988	34297	Beylikdüzü Vergi Dairesi Müdürlüğü
6735	34	988	34298	Esenyurt Vergi Dairesi Müdürlüğü
6736	34	988	34203	Silivri Vergi Dairesi Müdürlüğü
6737	34	988	34204	Büyükçekmece Vergi Dairesi Müdürlüğü
6738	34	988	34205	Şile Vergi Dairesi Müdürlüğü
6739	34	988	34230	Büyük Mükellefler Vergi Dairesi Başkanlığı
6740	34	988	34220	Haliç İhtisas Vergi Dairesi Müdürlüğü
6741	34	988	34221	Vatan İhtisas Vergi Dairesi Müdürlüğü
6742	34	988	34222	Çamlıca İhtisas Vergi Dairesi Müdürlüğü
6743	34	988	34223	Alemdağ Vergi Dairesi Müdürlüğü
6744	34	988	34224	Yenikapı Vergi Dairesi Müdürlüğü
6745	34	988	34231	Boğaziçi Kurumlar Vergi Dairesi Müdürlüğü
6746	34	988	34232	Marmara Kurumlar Vergi Dairesi Müdürlüğü
6747	34	988	34234	Davutpaşa Vergi Dairesi Müdürlüğü
6748	34	988	34235	Esenler Vergi Dairesi Müdürlüğü
6749	34	988	34236	Fatih Vergi Dairesi Müdürlüğü
6750	34	988	34237	Küçükköy Vergi Dairesi Müdürlüğü
6751	34	988	34239	Merter Vergi Dairesi Müdürlüğü
6752	34	988	34242	Sultanbeyli Vergi Dairesi Müdürlüğü
6753	34	988	34244	Anadolu Kurumlar Vergi Dairesi Müdürlüğü
6754	34	988	34245	Tuzla Vergi Dairesi Müdürlüğü
6755	34	988	34246	Kozyatağı Vergi Dairesi Müdürlüğü
6756	34	988	34247	Maslak Vergi Dairesi Müdürlüğü
6757	34	988	34248	Zincirlikuyu Vergi Dairesi Müdürlüğü
6758	34	988	34249	İkitelli Vergi Dairesi Müdürlüğü
6759	34	988	34251	Beşiktaş Vergi Dairesi Müdürlüğü
6760	34	988	34252	Ümraniye Vergi Dairesi Müdürlüğü
6761	34	988	34253	Yeditepe Veraset ve Harçlar Vergi Dairesi Müdürlüğü
6762	34	988	34254	Kasımpaşa Vergi Dairesi Müdürlüğü
6763	34	988	34255	Erenköy Vergi Dairesi Müdürlüğü
6764	34	988	34256	Hisar Veraset ve Harçlar Vergi Dairesi Müdürlüğü
6765	34	988	34257	Tuna Vergi Dairesi Müdürlüğü
6766	34	988	34258	Rıhtım Veraset ve Harçlar Vergi Dairesi Müdürlüğü
6767	34	988	34259	Güngören Vergi Dairesi Müdürlüğü
6768	34	988	34260	Kocasinan Vergi Dairesi Müdürlüğü
6769	34	988	34261	Güneşli Vergi Dairesi Müdürlüğü
6770	34	988	34262	Küçükyalı Vergi Dairesi Müdürlüğü
6771	34	988	34263	Pendik Vergi Dairesi Müdürlüğü
6772	34	988	34264	Bayrampaşa Vergi Dairesi Müdürlüğü
6773	34	988	34265	Beyazıt Vergi Dairesi Müdürlüğü
6774	34	988	34266	Beyoğlu Vergi Dairesi Müdürlüğü
6775	34	988	34269	Gaziosmanpaşa Vergi Dairesi Müdürlüğü
6776	34	988	34270	Göztepe Vergi Dairesi Müdürlüğü
6777	34	988	34271	Hocapaşa Vergi Dairesi Müdürlüğü
6778	34	988	34272	Kadıköy Vergi Dairesi Müdürlüğü
6779	34	988	34273	Kocamustafapaşa Vergi Dairesi Müdürlüğü
6780	34	988	34274	Mecidiyeköy Vergi Dairesi Müdürlüğü
6781	34	988	34276	Şişli Vergi Dairesi Müdürlüğü
6782	34	988	34277	Üsküdar Vergi Dairesi Müdürlüğü
6783	34	988	34278	Halkalı Vergi Dairesi Müdürlüğü
6784	34	988	34279	Kağıthane Vergi Dairesi Müdürlüğü
6785	34	988	34280	Zeytinburnu Vergi Dairesi Müdürlüğü
6786	34	988	34281	Beykoz Vergi Dairesi Müdürlüğü
6787	34	988	34283	Sarıyer Vergi Dairesi Müdürlüğü
6788	34	988	34284	Bakırköy Vergi Dairesi Müdürlüğü
6789	34	988	34285	Kartal Vergi Dairesi Müdürlüğü
6790	34	988	34287	Nakil Vasıtaları Vergi Dairesi Müdürlüğü
6791	34	988	34288	Sarıgazi Vergi Dairesi Müdürlüğü
6792	34	988	34291	Atışalanı Vergi Dairesi Müdürlüğü
6793	34	988	34292	Yakacık Vergi Dairesi Müdürlüğü
6794	34	988	34293	Yenibosna Vergi Dairesi Müdürlüğü
6795	35	986	35252	Yamanlar Vergi Dairesi Müdürlüğü
6796	35	986	35250	İzmir İhtisas Vergi Dairesi Müdürlüğü
6797	35	986	35251	9 Eylül Vergi Dairesi Müdürlüğü
6798	35	986	35254	Belkahve Vergi Dairesi Müdürlüğü
6799	35	986	35256	Karşıyaka Vergi Dairesi Müdürlüğü
6800	35	986	35257	Kemeraltı Vergi Dairesi Müdürlüğü
6801	35	986	35258	Konak Vergi Dairesi Müdürlüğü
6802	35	986	35259	Kordon Vergi Dairesi Müdürlüğü
6803	35	986	35260	Şirinyer Vergi Dairesi Müdürlüğü
6804	35	986	35261	Kadifekale Vergi Dairesi Müdürlüğü
6805	35	986	35262	Taşıtlar Vergi Dairesi Müdürlüğü
6806	35	986	35263	Hasan Tahsin Vergi Dairesi Müdürlüğü
6807	35	986	35264	Bornova Vergi Dairesi Müdürlüğü
6808	35	986	35266	Balçova Vergi Dairesi Müdürlüğü
6809	35	986	35267	Gaziemir Vergi Dairesi Müdürlüğü
6810	35	986	35268	Ege Vergi Dairesi Müdürlüğü
6811	35	986	35269	Çiğli Vergi Dairesi Müdürlüğü
6812	35	986	35270	Çakabey İhtisas Vergi Dairesi Müdürlüğü
6813	35	460	35201	Bayındır Vergi Dairesi Müdürlüğü
6814	35	461	35202	Bergama Vergi Dairesi Müdürlüğü
6815	35	986	35203	Menemen Vergi Dairesi Müdürlüğü
6816	35	472	35204	Ödemiş Vergi Dairesi Müdürlüğü
6817	35	475	35205	Tire Vergi Dairesi Müdürlüğü
6818	35	986	35206	Torbalı Vergi Dairesi Müdürlüğü
6819	35	986	35207	Kemalpaşa Vergi Dairesi Müdürlüğü
6820	35	986	35208	Urla Vergi Dairesi Müdürlüğü
6821	35	474	35209	Selçuk Vergi Dairesi Müdürlüğü
6822	35	469	35210	Kınık Vergi Dairesi Müdürlüğü
6823	35	470	35211	Kiraz Vergi Dairesi Müdürlüğü
6824	35	463	35212	Çeşme Vergi Dairesi Müdürlüğü
6825	35	986	35213	Aliağa Vergi Dairesi Müdürlüğü
6826	35	986	35215	Menderes Vergi Dairesi Müdürlüğü
6827	35	464	35105	Dikili Malmüdürlüğü
6828	35	986	35106	Foça Malmüdürlüğü
6829	35	466	35107	Karaburun Malmüdürlüğü
6830	35	986	35114	Seferihisar Malmüdürlüğü
6831	35	478	35120	Beydağ Malmüdürlüğü
6832	36	495	36113	Susuz Malmüdürlüğü
6833	36	492	36260	Kars Vergi Dairesi Müdürlüğü
6834	36	494	36112	Selim Malmüdürlüğü
6835	36	493	36111	Sarıkamış Malmüdürlüğü
6836	36	496	36115	Akyaka Malmüdürlüğü
6837	36	489	36103	Arpaçay Malmüdürlüğü
6838	36	491	36109	Kağızman Malmüdürlüğü
6839	36	490	36105	Digor Malmüdürlüğü
6840	37	497	37112	Abana Malmüdürlüğü
6841	37	509	37261	Tosya Vergi Dairesi Müdürlüğü
6842	37	502	37105	Çatalzeytin Malmüdürlüğü
6843	37	501	37104	Cide Malmüdürlüğü
6844	37	510	37113	İhsangazi Malmüdürlüğü
6845	37	511	37114	Pınarbaşı Malmüdürlüğü
6846	37	512	37115	Şenpazar Malmüdürlüğü
6847	37	513	37116	Ağlı Malmüdürlüğü
6848	37	514	37117	Doğanyurt Malmüdürlüğü
6849	37	515	37118	Hanönü Malmüdürlüğü
6850	37	516	37119	Seydiler Malmüdürlüğü
6851	37	500	37103	Bozkurt Malmüdürlüğü
6852	37	506	37260	Kastamonu Vergi Dairesi Müdürlüğü
6853	37	503	37106	Daday Malmüdürlüğü
6854	37	504	37107	Devrekani Malmüdürlüğü
6855	37	499	37102	Azdavay Malmüdürlüğü
6856	37	498	37101	Araç Malmüdürlüğü
6857	37	508	37262	Taşköprü Vergi Dairesi Müdürlüğü
6858	37	505	37108	İnebolu Malmüdürlüğü
6859	37	507	37109	Küre Malmüdürlüğü
6860	38	524	38108	Tomarza Malmüdürlüğü
6861	38	976	38250	Kayseri İhtisas Vergi Dairesi Müdürlüğü
6862	38	976	38251	Mimar Sinan Vergi Dairesi Müdürlüğü
6863	38	976	38252	Erciyes Vergi Dairesi Müdürlüğü
6864	38	976	38253	Kaleönü Vergi Dairesi Müdürlüğü
6865	38	976	38254	Gevher Nesibe Vergi Dairesi Müdürlüğü
6866	38	518	38201	Develi Vergi Dairesi Müdürlüğü
6867	38	521	38202	Pınarbaşı Vergi Dairesi Müdürlüğü
6868	38	517	38203	Bünyan Vergi Dairesi Müdürlüğü
6869	38	519	38103	Felahiye Malmüdürlüğü
6870	38	520	38104	İncesu Malmüdürlüğü
6871	38	522	38106	Sarıoğlan Malmüdürlüğü
6872	38	523	38107	Sarız Malmüdürlüğü
6873	38	525	38109	Yahyalı Malmüdürlüğü
6874	38	526	38110	Yeşilhisar Malmüdürlüğü
6875	38	527	38111	Akkışla Malmüdürlüğü
6876	38	976	38113	Hacılar Malmüdürlüğü
6877	38	532	38114	Özvatan Malmüdürlüğü
6878	39	534	39102	Demirköy Malmüdürlüğü
6879	39	536	39103	Kofçaz Malmüdürlüğü
6880	39	538	39105	Pehlivanköy Malmüdürlüğü
6881	39	539	39106	Pınarhisar Malmüdürlüğü
6882	39	540	39107	Vize Malmüdürlüğü
6883	39	533	39262	Babaeski Vergi Dairesi Müdürlüğü
6884	39	537	39261	Lüleburgaz Vergi Dairesi Müdürlüğü
6885	39	535	39260	Kırklareli Vergi Dairesi Müdürlüğü
6886	40	544	40103	Mucur Malmüdürlüğü
6887	40	545	40104	Akpınar Malmüdürlüğü
6888	40	546	40105	Akçakent Malmüdürlüğü
6889	40	547	40106	Boztepe Malmüdürlüğü
6890	40	543	40260	Kırşehir Vergi Dairesi Müdürlüğü
6891	40	542	40261	Kaman Vergi Dairesi Müdürlüğü
6892	40	541	40101	Çiçekdağı Malmüdürlüğü
6893	41	992	41253	Alemdar Vergi Dairesi Müdürlüğü
6894	41	548	41254	Gebze İhtisas Vergi Dairesi Müdürlüğü
6895	41	992	41250	Kocaeli İhtisas Vergi Dairesi Müdürlüğü
6896	41	992	41252	Tepecik Vergi Dairesi Müdürlüğü
6897	41	992	41290	Acısu Vergi Dairesi Müdürlüğü
6898	41	992	41202	Uluçınar Vergi Dairesi Müdürlüğü
6899	41	992	41203	İlyasbey Vergi Dairesi Müdürlüğü
6900	41	992	41204	Gölcük Vergi Dairesi Müdürlüğü
6901	41	992	41205	Karamürsel Vergi Dairesi Müdürlüğü
6902	41	992	41206	Körfez Vergi Dairesi Müdürlüğü
6903	41	992	41207	Derince Vergi Dairesi Müdürlüğü
6904	41	992	41103	Kandıra Malmüdürlüğü
6905	42	562	42103	Bozkır Malmüdürlüğü
6906	42	560	42201	Akşehir Vergi Dairesi Müdürlüğü
6907	42	566	42202	Ereğli Vergi Dairesi Müdürlüğü
6908	42	561	42204	Beyşehir Vergi Dairesi Müdürlüğü
6909	42	563	42205	Cihanbeyli Vergi Dairesi Müdürlüğü
6910	42	564	42206	Çumra Vergi Dairesi Müdürlüğü
6911	42	573	42207	Seydişehir Vergi Dairesi Müdürlüğü
6912	42	568	42208	Ilgın Vergi Dairesi Müdürlüğü
6913	42	571	42209	Kulu Vergi Dairesi Müdürlüğü
6914	42	570	42210	Karapınar Vergi Dairesi Müdürlüğü
6915	42	1000	42254	Alaaddin Vergi Dairesi Müdürlüğü
6916	42	565	42106	Doğanhisar Malmüdürlüğü
6917	42	567	42109	Hadim Malmüdürlüğü
6918	42	569	42111	Kadınhanı Malmüdürlüğü
6919	42	572	42115	Sarayönü Malmüdürlüğü
6920	42	574	42117	Yunak Malmüdürlüğü
6921	42	575	42118	Akören Malmüdürlüğü
6922	42	576	42119	Altınekin Malmüdürlüğü
6923	42	577	42121	Derebucak Malmüdürlüğü
6924	42	578	42122	Hüyük Malmüdürlüğü
6925	42	582	42123	Taşkent Malmüdürlüğü
6926	42	583	42124	Ahırlı Malmüdürlüğü
6927	42	584	42125	Çeltik Malmüdürlüğü
6928	42	585	42126	Derbent Malmüdürlüğü
6929	42	586	42127	Emirgazi Malmüdürlüğü
6930	42	587	42128	Güneysınır Malmüdürlüğü
6931	42	588	42129	Halkapınar Malmüdürlüğü
6932	42	589	42130	Tuzlukçu Malmüdürlüğü
6933	42	590	42131	Yalıhüyük Malmüdürlüğü
6934	42	1000	42253	Meram Vergi Dairesi Müdürlüğü
6935	42	1000	42252	Mevlana Vergi Dairesi Müdürlüğü
6936	42	1000	42251	Selçuk Vergi Dairesi Müdürlüğü
6937	42	1000	42250	Konya İhtisas Vergi Dairesi Müdürlüğü
6938	43	597	43262	Tavşanlı Vergi Dairesi Müdürlüğü
6939	43	593	43263	Emet Vergi Dairesi Müdürlüğü
6940	43	591	43101	Altıntaş Malmüdürlüğü
6941	43	592	43102	Domaniç Malmüdürlüğü
6942	43	598	43107	Aslanapa Malmüdürlüğü
6943	43	599	43108	Dumlupınar Malmüdürlüğü
6944	43	600	43109	Hisarcık Malmüdürlüğü
6945	43	601	43110	Şaphane Malmüdürlüğü
6946	43	602	43111	Çavdarhisar Malmüdürlüğü
6947	43	603	43112	Pazarlar Malmüdürlüğü
6948	43	595	43201	30 Ağustos Vergi Dairesi Müdürlüğü
6949	43	595	43280	Çinili Vergi Dairesi Müdürlüğü
6950	43	594	43260	Gediz Vergi Dairesi Müdürlüğü
6951	43	596	43261	Simav Vergi Dairesi Müdürlüğü
6952	44	606	44103	Arguvan Malmüdürlüğü
6953	44	1001	44251	Fırat Vergi Dairesi Müdürlüğü
6954	44	1001	44252	Beydağı Vergi Dairesi Müdürlüğü
6955	44	604	44101	Akçadağ Malmüdürlüğü
6956	44	605	44102	Arapgir Malmüdürlüğü
6957	44	607	44104	Darende Malmüdürlüğü
6958	44	608	44105	Doğanşehir Malmüdürlüğü
6959	44	609	44106	Hekimhan Malmüdürlüğü
6960	44	610	44107	Pütürge Malmüdürlüğü
6961	44	611	44108	Yeşilyurt Malmüdürlüğü
6962	44	612	44109	Battalgazi Malmüdürlüğü
6963	44	613	44110	Doğanyol Malmüdürlüğü
6964	44	614	44111	Kale Malmüdürlüğü
6965	44	615	44112	Kuluncak Malmüdürlüğü
6966	44	616	44113	Yazıhan Malmüdürlüğü
6967	45	617	45201	Akhisar Vergi Dairesi Müdürlüğü
6968	45	627	45208	Soma Vergi Dairesi Müdürlüğü
6969	45	628	45209	Turgutlu Vergi Dairesi Müdürlüğü
6970	45	618	45202	Alaşehir Vergi Dairesi Müdürlüğü
6971	45	620	45210	Gördes Vergi Dairesi Müdürlüğü
6972	45	622	45211	Kula Vergi Dairesi Müdürlüğü
6973	45	624	45206	Sarıgöl Vergi Dairesi Müdürlüğü
6974	45	623	45205	Salihli Adil Oral Vergi Dairesi Müdürlüğü
6975	45	621	45204	Kırkağaç Vergi Dairesi Müdürlüğü
6976	45	619	45203	Demirci Vergi Dairesi Müdürlüğü
6977	45	626	45110	Selendi Malmüdürlüğü
6978	45	629	45113	Ahmetli Malmüdürlüğü
6979	45	630	45114	Gölmarmara Malmüdürlüğü
6980	45	631	45115	Köprübaşı Malmüdürlüğü
6981	45	625	45207	Saruhanlı Vergi Dairesi Müdürlüğü
6982	45	997	45250	Manisa İhtisas Vergi Dairesi Müdürlüğü
6983	45	997	45251	Şehit Cihan Güneş Vergi Dairesi Müdürlüğü
6984	45	997	45252	Mesir Vergi Dairesi Müdürlüğü
6985	46	638	46262	Pazarcık Vergi Dairesi Müdürlüğü
6986	46	635	46102	Andırın Malmüdürlüğü
6987	46	637	46104	Göksun Malmüdürlüğü
6988	46	639	46106	Türkoğlu Malmüdürlüğü
6989	46	640	46107	Çağlayancerit Malmüdürlüğü
6990	46	641	46108	Ekinözü Malmüdürlüğü
6991	46	642	46109	Nurhak Malmüdürlüğü
6992	46	998	46201	Aslanbey Vergi Dairesi Müdürlüğü
6993	46	998	46280	Aksu Vergi Dairesi Müdürlüğü
6994	46	636	46260	Elbistan Vergi Dairesi Müdürlüğü
6995	46	634	46261	Afşin Vergi Dairesi Müdürlüğü
6996	47	651	47110	Savur Malmüdürlüğü
6997	47	993	47260	Mardin Vergi Dairesi Müdürlüğü
6998	47	646	47261	Kızıltepe Vergi Dairesi Müdürlüğü
6999	47	649	47262	Nusaybin Vergi Dairesi Müdürlüğü
7000	47	645	47102	Derik Malmüdürlüğü
7001	47	647	47106	Mazıdağı Malmüdürlüğü
7002	47	648	47107	Midyat Malmüdürlüğü
7003	47	650	47109	Ömerli Malmüdürlüğü
7004	47	652	47112	Dargeçit Malmüdürlüğü
7005	47	653	47113	Yeşilli Malmüdürlüğü
7006	48	660	48264	Milas Vergi Dairesi Müdürlüğü
7007	48	659	48265	Marmaris Vergi Dairesi Müdürlüğü
7008	48	662	48266	Yatağan Vergi Dairesi Müdürlüğü
7009	48	656	48102	Datça Malmüdürlüğü
7010	48	661	48108	Ula Malmüdürlüğü
7011	48	663	48109	Dalaman Malmüdürlüğü
7012	48	664	48110	Ortaca Malmüdürlüğü
7013	48	665	48111	Kavaklıdere Malmüdürlüğü
7014	48	658	48263	Köyceğiz Vergi Dairesi Müdürlüğü
7015	48	657	48262	Fethiye Vergi Dairesi Müdürlüğü
7016	48	655	48261	Bodrum Vergi Dairesi Müdürlüğü
7017	48	994	48260	Muğla Vergi Dairesi Müdürlüğü
7018	48	667	48113	Seydikemer Malmüdürlüğü
7019	49	673	49105	Korkut Malmüdürlüğü
7020	49	670	49260	Muş Vergi Dairesi Müdürlüğü
7021	49	668	49101	Bulanık Malmüdürlüğü
7022	49	669	49102	Malazgirt Malmüdürlüğü
7023	49	671	49103	Varto Malmüdürlüğü
7024	49	672	49104	Hasköy Malmüdürlüğü
7025	50	678	50105	Kozaklı Malmüdürlüğü
7026	50	679	50260	Nevşehir Vergi Dairesi Müdürlüğü
7027	50	674	50101	Avanos Malmüdürlüğü
7028	50	675	50102	Derinkuyu Malmüdürlüğü
7029	50	676	50103	Gülşehir Malmüdürlüğü
7030	50	677	50104	Hacıbektaş Malmüdürlüğü
7031	50	681	50107	Acıgöl Malmüdürlüğü
7032	50	680	50106	Ürgüp Malmüdürlüğü
7033	51	684	51260	Niğde Vergi Dairesi Müdürlüğü
7034	51	683	51103	Çamardı Malmüdürlüğü
7035	51	685	51105	Ulukışla Malmüdürlüğü
7036	51	686	51106	Altunhisar Malmüdürlüğü
7037	51	687	51107	Çiftlik Malmüdürlüğü
7038	51	682	51262	Bor Vergi Dairesi Müdürlüğü
7039	52	699	52112	Gürgentepe Malmüdürlüğü
7040	52	700	52113	Çamaş Malmüdürlüğü
7041	52	701	52114	Çatalpınar Malmüdürlüğü
7042	52	702	52115	Çaybaşı Malmüdürlüğü
7043	52	703	52116	İkizce Malmüdürlüğü
7044	52	704	52117	Kabadüz Malmüdürlüğü
7045	52	705	52118	Kabataş Malmüdürlüğü
7046	52	995	52201	Boztepe Vergi Dairesi Müdürlüğü
7047	52	995	52260	Köprübaşı Vergi Dairesi Müdürlüğü
7048	52	690	52261	Fatsa Vergi Dairesi Müdürlüğü
7049	52	697	52262	Ünye Vergi Dairesi Müdürlüğü
7050	52	688	52101	Akkuş Malmüdürlüğü
7051	52	689	52102	Aybastı Malmüdürlüğü
7052	52	691	52104	Gölköy Malmüdürlüğü
7053	52	692	52105	Korgan Malmüdürlüğü
7054	52	693	52106	Kumru Malmüdürlüğü
7055	52	694	52107	Mesudiye Malmüdürlüğü
7056	52	695	52108	Perşembe Malmüdürlüğü
7057	52	696	52109	Ulubey Malmüdürlüğü
7058	52	698	52111	Gülyalı Malmüdürlüğü
7059	53	708	53102	Çamlıhemşin Malmüdürlüğü
7060	53	710	53104	Fındıklı Malmüdürlüğü
7061	53	711	53105	İkizdere Malmüdürlüğü
7062	53	712	53106	Kalkandere Malmüdürlüğü
7063	53	715	53108	Güneysu Malmüdürlüğü
7064	53	716	53109	Derepazarı Malmüdürlüğü
7065	53	717	53110	Hemşin Malmüdürlüğü
7066	53	718	53111	İyidere Malmüdürlüğü
7067	53	707	53263	Ardeşen Vergi Dairesi Müdürlüğü
7068	53	713	53262	Pazar Vergi Dairesi Müdürlüğü
7069	53	709	53261	Çayeli Vergi Dairesi Müdürlüğü
7070	53	714	53260	Yeşilçay Vergi Dairesi Müdürlüğü
7071	53	714	53201	Kaçkar Vergi Dairesi Müdürlüğü
7072	54	996	54203	Hendek Vergi Dairesi Müdürlüğü
7073	54	996	54250	Sakarya İhtisas Vergi Dairesi Müdürlüğü
7074	54	996	54251	Gümrükönü Vergi Dairesi Müdürlüğü
7075	54	996	54252	Ali Fuat Cebesoy Vergi Dairesi Müdürlüğü
7076	54	996	54253	Sapanca Vergi Dairesi Müdürlüğü
7077	54	996	54201	Akyazı Vergi Dairesi Müdürlüğü
7078	54	720	54202	Geyve Vergi Dairesi Müdürlüğü
7079	54	722	54204	Karasu Vergi Dairesi Müdürlüğü
7080	54	723	54105	Kaynarca Malmüdürlüğü
7081	54	725	54107	Kocaali Malmüdürlüğü
7082	54	726	54108	Pamukova Malmüdürlüğü
7083	54	727	54109	Taraklı Malmüdürlüğü
7084	54	996	54111	Karapürçek Malmüdürlüğü
7085	55	742	55108	Vezirköprü Malmüdürlüğü
7086	55	739	55105	Kavak Malmüdürlüğü
7087	55	741	55204	Terme Vergi Dairesi Müdürlüğü
7088	55	735	55101	Alaçam Malmüdürlüğü
7089	55	738	55205	Havza Vergi Dairesi Müdürlüğü
7090	55	973	55251	19 Mayıs Vergi Dairesi Müdürlüğü
7091	55	743	55109	Asarcık Malmüdürlüğü
7092	55	745	55111	Salıpazarı Malmüdürlüğü
7093	55	748	55114	Yakakent Malmüdürlüğü
7094	55	747	55113	Ayvacık Malmüdürlüğü
7095	55	973	55112	Tekkeköy Malmüdürlüğü
7096	55	973	55252	Gaziler Vergi Dairesi Müdürlüğü
7097	55	973	55290	Zafer Vergi Dairesi Müdürlüğü
7098	55	736	55202	Bafra Vergi Dairesi Müdürlüğü
7099	55	737	55203	Çarşamba Vergi Dairesi Müdürlüğü
7100	55	744	55110	Ondokuz Mayıs Malmüdürlüğü
7101	55	740	55106	Ladik Malmüdürlüğü
7102	56	752	56102	Baykan Malmüdürlüğü
7103	56	753	56104	Eruh Malmüdürlüğü
7104	56	754	56106	Kurtalan Malmüdürlüğü
7105	56	756	56260	Siirt Vergi Dairesi Müdürlüğü
7106	56	755	56107	Pervari Malmüdürlüğü
7107	56	757	56110	Şirvan Malmüdürlüğü
7108	57	763	57105	Gerze Malmüdürlüğü
7109	57	765	57106	Türkeli Malmüdürlüğü
7110	57	767	57108	Saraydüzü Malmüdürlüğü
7111	57	766	57107	Dikmen Malmüdürlüğü
7112	57	760	57261	Boyabat Vergi Dairesi Müdürlüğü
7113	57	759	57101	Ayancık Malmüdürlüğü
7114	57	761	57103	Durağan Malmüdürlüğü
7115	57	764	57260	Sinop Vergi Dairesi Müdürlüğü
7116	57	762	57104	Erfelek Malmüdürlüğü
7117	58	779	58111	Zara Malmüdürlüğü
7118	58	775	58201	Kale Vergi Dairesi Müdürlüğü
7119	58	775	58280	Site Vergi Dairesi Müdürlüğü
7120	58	777	58260	Şarkışla Vergi Dairesi Müdürlüğü
7121	58	768	58101	Divriği Malmüdürlüğü
7122	58	769	58102	Gemerek Malmüdürlüğü
7123	58	770	58103	Gürün Malmüdürlüğü
7124	58	771	58104	Hafik Malmüdürlüğü
7125	58	772	58105	İmranlı Malmüdürlüğü
7126	58	773	58106	Kangal Malmüdürlüğü
7127	58	774	58107	Koyulhisar Malmüdürlüğü
7128	58	776	58109	Suşehri Malmüdürlüğü
7129	58	778	58110	Yıldızeli Malmüdürlüğü
7130	58	780	58112	Akıncılar Malmüdürlüğü
7131	58	781	58113	Altınyayla Malmüdürlüğü
7132	58	782	58114	Doğanşar Malmüdürlüğü
7133	58	783	58115	Gölova Malmüdürlüğü
7134	58	784	58116	Ulaş Malmüdürlüğü
7135	59	788	59264	Malkara Vergi Dairesi Müdürlüğü
7136	59	789	59265	Muratlı Vergi Dairesi Müdürlüğü
7137	59	791	59266	Şarköy Vergi Dairesi Müdürlüğü
7138	59	794	59267	Kapaklı Vergi Dairesi Müdürlüğü
7139	59	790	59106	Saray Malmüdürlüğü
7140	59	792	59108	Marmara Ereğlisi Malmüdürlüğü
7141	59	787	59263	Hayrabolu Vergi Dairesi Müdürlüğü
7142	59	786	59262	Çorlu Vergi Dairesi Müdürlüğü
7143	59	785	59261	Çerkezköy Vergi Dairesi Müdürlüğü
7144	59	786	59250	Çorlu İhtisas Vergi Dairesi Müdürlüğü
7145	59	983	59260	Namık Kemal Vergi Dairesi Müdürlüğü
7146	59	983	59201	Süleymanpaşa Vergi Dairesi Müdürlüğü
7147	60	803	60264	Zile Vergi Dairesi Müdürlüğü
7148	60	801	60260	Tokat Vergi Dairesi Müdürlüğü
7149	60	798	60261	Erbaa Vergi Dairesi Müdürlüğü
7150	60	799	60262	Niksar Vergi Dairesi Müdürlüğü
7151	60	802	60263	Turhal Vergi Dairesi Müdürlüğü
7152	60	796	60101	Almus Malmüdürlüğü
7153	60	797	60102	Artova Malmüdürlüğü
7154	60	800	60105	Reşadiye Malmüdürlüğü
7155	60	804	60108	Pazar Malmüdürlüğü
7156	60	805	60109	Yeşilyurt Malmüdürlüğü
7157	60	806	60110	Başçiftlik Malmüdürlüğü
7158	60	807	60111	Sulusaray Malmüdürlüğü
7159	61	819	61112	Şalpazarı Malmüdürlüğü
7160	61	810	61103	Arsin Malmüdürlüğü
7161	61	989	61201	Hızırbey Vergi Dairesi Müdürlüğü
7162	61	989	61280	Karadeniz Vergi Dairesi Müdürlüğü
7163	61	808	61260	Akçaabat Vergi Dairesi Müdürlüğü
7164	61	813	61261	Of Vergi Dairesi Müdürlüğü
7165	61	816	61262	Vakfıkebir Vergi Dairesi Müdürlüğü
7166	61	809	61102	Araklı Malmüdürlüğü
7167	61	820	61113	Çarşıbaşı Malmüdürlüğü
7168	61	821	61114	Dernekpazarı Malmüdürlüğü
7169	61	822	61115	Düzköy Malmüdürlüğü
7170	61	823	61116	Hayrat Malmüdürlüğü
7171	61	824	61117	Köprübaşı Malmüdürlüğü
7172	61	811	61104	Çaykara Malmüdürlüğü
7173	61	812	61105	Maçka Malmüdürlüğü
7174	61	814	61107	Sürmene Malmüdürlüğü
7175	61	815	61108	Tonya Malmüdürlüğü
7176	61	817	61110	Yomra Malmüdürlüğü
7177	61	818	61111	Beşikdüzü Malmüdürlüğü
7178	62	829	62104	Nazimiye Malmüdürlüğü
7179	62	833	62260	Tunceli Vergi Dairesi Müdürlüğü
7180	62	826	62101	Çemişgezek Malmüdürlüğü
7181	62	827	62102	Hozat Malmüdürlüğü
7182	62	828	62103	Mazgirt Malmüdürlüğü
7183	62	830	62105	Ovacık Malmüdürlüğü
7184	62	831	62106	Pertek Malmüdürlüğü
7185	62	832	62107	Pülümür Malmüdürlüğü
7186	63	834	63101	Akçakale Malmüdürlüğü
7187	63	836	63103	Bozova Malmüdürlüğü
7188	63	838	63104	Halfeti Malmüdürlüğü
7189	63	839	63105	Hilvan Malmüdürlüğü
7190	63	837	63109	Ceylanpınar Malmüdürlüğü
7191	63	843	63110	Harran Malmüdürlüğü
7192	63	835	63262	Birecik Vergi Dairesi Müdürlüğü
7193	63	842	63261	Viranşehir Vergi Dairesi Müdürlüğü
7194	63	840	63260	Siverek Vergi Dairesi Müdürlüğü
7195	63	990	63281	Göbeklitepe Vergi Dairesi Müdürlüğü
7196	63	990	63280	Topçu Meydanı Vergi Dairesi Müdürlüğü
7197	63	990	63201	Şehitlik Vergi Dairesi Müdürlüğü
7198	63	841	63263	Suruç Vergi Dairesi Müdürlüğü
7199	64	852	64260	Uşak Vergi Dairesi Müdürlüğü
7200	64	847	64261	Banaz Vergi Dairesi Müdürlüğü
7201	64	848	64262	Eşme Vergi Dairesi Müdürlüğü
7202	64	849	64103	Karahallı Malmüdürlüğü
7203	64	851	64104	Ulubey Malmüdürlüğü
7204	64	850	64105	Sivaslı Malmüdürlüğü
7205	65	853	65101	Başkale Malmüdürlüğü
7206	65	991	65260	Van Vergi Dairesi Müdürlüğü
7207	65	855	65201	Erciş Vergi Dairesi Müdürlüğü
7208	65	854	65102	Çatak Malmüdürlüğü
7209	65	856	65104	Gevaş Malmüdürlüğü
7210	65	857	65105	Gürpınar Malmüdürlüğü
7211	65	858	65106	Muradiye Malmüdürlüğü
7212	65	859	65107	Özalp Malmüdürlüğü
7213	65	860	65108	Bahçesaray Malmüdürlüğü
7214	65	861	65109	Çaldıran Malmüdürlüğü
7215	65	862	65110	Edremit Malmüdürlüğü
7216	65	863	65111	Saray Malmüdürlüğü
7217	66	874	66260	Yozgat Vergi Dairesi Müdürlüğü
7218	66	867	66261	Boğazlıyan Vergi Dairesi Müdürlüğü
7219	66	871	66262	Sorgun Vergi Dairesi Müdürlüğü
7220	66	873	66263	Yerköy Vergi Dairesi Müdürlüğü
7221	66	866	66101	Akdağmadeni Malmüdürlüğü
7222	66	868	66103	Çayıralan Malmüdürlüğü
7223	66	869	66104	Çekerek Malmüdürlüğü
7224	66	872	66106	Şefaatli Malmüdürlüğü
7225	66	875	66109	Aydıncık Malmüdürlüğü
7226	66	876	66110	Çandır Malmüdürlüğü
7227	66	877	66111	Kadışehri Malmüdürlüğü
7228	66	878	66112	Saraykent Malmüdürlüğü
7229	66	870	66105	Sarıkaya Malmüdürlüğü
7230	66	879	66113	Yenifakılı Malmüdürlüğü
7231	67	885	67113	Gökçebey Malmüdürlüğü
7232	67	884	67110	Alaplı Malmüdürlüğü
7233	67	881	67264	Devrek Vergi Dairesi Müdürlüğü
7234	67	880	67263	Çaycuma Vergi Dairesi Müdürlüğü
7235	67	882	67261	Ereğli Vergi Dairesi Müdürlüğü
7236	67	883	67280	Kara Elmas Vergi Dairesi Müdürlüğü
7237	67	883	67201	Uzunmehmet Vergi Dairesi Müdürlüğü
7238	68	888	68201	Aksaray Vergi Dairesi Müdürlüğü
7239	68	890	68101	Ağaçören Malmüdürlüğü
7240	68	891	68102	Güzelyurt Malmüdürlüğü
7241	68	889	68103	Ortaköy Malmüdürlüğü
7242	68	892	68104	Sarıyahşi Malmüdürlüğü
7243	68	893	68105	Eskil Malmüdürlüğü
7244	68	894	68106	Gülağaç Malmüdürlüğü
7245	69	896	69101	Aydıntepe Malmüdürlüğü
7246	69	897	69102	Demirözü Malmüdürlüğü
7247	69	895	69201	Bayburt Vergi Dairesi Müdürlüğü
7248	70	902	70104	Başyayla Malmüdürlüğü
7249	70	903	70105	Sarıveliler Malmüdürlüğü
7250	70	901	70103	Kazım Karabekir Malmüdürlüğü
7251	70	898	70102	Ermenek Malmüdürlüğü
7252	70	900	70101	Ayrancı Malmüdürlüğü
7253	70	899	70201	Karaman Vergi Dairesi Müdürlüğü
7254	71	910	71106	Çelebi Malmüdürlüğü
7255	71	904	71101	Delice Malmüdürlüğü
7256	71	906	71202	Kaletepe Vergi Dairesi Müdürlüğü
7257	71	905	71102	Keskin Malmüdürlüğü
7258	71	907	71103	Sulakyurt Malmüdürlüğü
7259	71	909	71105	Balışeyh Malmüdürlüğü
7260	71	911	71107	Karakeçili Malmüdürlüğü
7261	71	906	71201	Irmak Vergi Dairesi Müdürlüğü
7262	72	913	72260	Batman Vergi Dairesi Müdürlüğü
7263	72	914	72101	Beşiri Malmüdürlüğü
7264	72	915	72102	Gercüş Malmüdürlüğü
7265	72	918	72103	Hasankeyf Malmüdürlüğü
7266	72	916	72104	Kozluk Malmüdürlüğü
7267	72	917	72105	Sason Malmüdürlüğü
7268	73	921	73104	İdil Malmüdürlüğü
7269	73	923	73260	Şırnak Vergi Dairesi Müdürlüğü
7270	73	920	73261	Cizre Vergi Dairesi Müdürlüğü
7271	73	922	73262	Silopi Vergi Dairesi Müdürlüğü
7272	73	919	73101	Beytüşşebap Malmüdürlüğü
7273	73	925	73103	Güçlükonak Malmüdürlüğü
7274	73	924	73106	Uludere Malmüdürlüğü
7275	74	929	74101	Amasra Malmüdürlüğü
7276	74	927	74102	Kurucaşile Malmüdürlüğü
7277	74	928	74103	Ulus Malmüdürlüğü
7278	74	926	74260	Bartın Vergi Dairesi Müdürlüğü
7279	75	932	75103	Göle Malmüdürlüğü
7280	75	933	75104	Hanak Malmüdürlüğü
7281	75	934	75105	Posof Malmüdürlüğü
7282	75	935	75102	Damal Malmüdürlüğü
7283	75	931	75101	Çıldır Malmüdürlüğü
7284	75	930	75201	Ardahan Vergi Dairesi Müdürlüğü
7285	76	939	76102	Karakoyunlu Malmüdürlüğü
7286	76	938	76103	Tuzluca Malmüdürlüğü
7287	76	937	76201	Iğdır Vergi Dairesi Müdürlüğü
7288	76	936	76101	Aralık Malmüdürlüğü
7289	77	943	77103	Çınarcık Malmüdürlüğü
7290	77	940	77201	Yalova Vergi Dairesi Müdürlüğü
7291	77	941	77101	Altınova Malmüdürlüğü
7292	77	942	77102	Armutlu Malmüdürlüğü
7293	78	948	78201	Karabük Vergi Dairesi Müdürlüğü
7294	78	951	78105	Yenice Malmüdürlüğü
7295	78	949	78103	Ovacık Malmüdürlüğü
7296	78	947	78102	Eskipazar Malmüdürlüğü
7297	78	950	78260	Safranbolu Vergi Dairesi Müdürlüğü
7298	78	946	78101	Eflani Malmüdürlüğü
7299	79	952	79201	Kilis Vergi Dairesi Müdürlüğü
7300	80	958	80201	Osmaniye Vergi Dairesi Müdürlüğü
7301	80	957	80260	Kadirli Vergi Dairesi Müdürlüğü
7302	80	956	80101	Bahçe Malmüdürlüğü
7303	80	959	80102	Düziçi Malmüdürlüğü
7304	80	960	80104	Hasanbeyli Malmüdürlüğü
7305	80	961	80105	Sumbas Malmüdürlüğü
7306	80	962	80106	Toprakkale Malmüdürlüğü
7307	81	965	81107	Yığılca Malmüdürlüğü
7308	81	970	81106	Kaynaşlı Malmüdürlüğü
7309	81	969	81105	Gümüşova Malmüdürlüğü
7310	81	967	81104	Gölyaka Malmüdürlüğü
7311	81	968	81103	Çilimli Malmüdürlüğü
7312	81	966	81102	Cumayeri Malmüdürlüğü
7313	81	963	81261	Akçakoca Vergi Dairesi Müdürlüğü
7314	81	964	81260	Düzce Vergi Dairesi Müdürlüğü
\.


--
-- Data for Name: user_coupons; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.user_coupons (id, coupon_id, user_id) FROM stdin;
\.


--
-- Data for Name: user_favourite_products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.user_favourite_products (id, user_id, product_id) FROM stdin;
\.


--
-- Data for Name: user_products_will_be_ordered; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.user_products_will_be_ordered (id, user_id, product_id) FROM stdin;
\.


--
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id, email, name, surname, phone, birthdate, gender, email_notification_enabled, sms_notification_enabled) FROM stdin;
\.


--
-- Name: addresses_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.addresses_id_seq', 1, false);


--
-- Name: banks_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.banks_id_seq', 47, true);


--
-- Name: brands_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.brands_id_seq', 1, false);


--
-- Name: campaigns_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.campaigns_id_seq', 1, false);


--
-- Name: categories_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.categories_id_seq', 1, false);


--
-- Name: cities_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.cities_id_seq', 81, true);


--
-- Name: coupons_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.coupons_id_seq', 1, false);


--
-- Name: districts_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.districts_id_seq', 1001, true);


--
-- Name: faq_categories_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.faq_categories_id_seq', 1, false);


--
-- Name: faq_subcategories_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.faq_subcategories_id_seq', 1, false);


--
-- Name: faqs_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.faqs_id_seq', 1, false);


--
-- Name: invoices_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.invoices_id_seq', 1, false);


--
-- Name: order_products_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.order_products_id_seq', 1, false);


--
-- Name: orders_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.orders_id_seq', 1, false);


--
-- Name: product_campaigns_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.product_campaigns_id_seq', 1, false);


--
-- Name: product_rates_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.product_rates_id_seq', 1, false);


--
-- Name: products_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.products_id_seq', 1, false);


--
-- Name: shop_products_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.shop_products_id_seq', 1, false);


--
-- Name: shops_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.shops_id_seq', 1, false);


--
-- Name: slides_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.slides_id_seq', 1, false);


--
-- Name: subcategories_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.subcategories_id_seq', 1, false);


--
-- Name: subsubcategories_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.subsubcategories_id_seq', 1, false);


--
-- Name: tax_offices_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tax_offices_id_seq', 7314, true);


--
-- Name: user_coupons_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.user_coupons_id_seq', 1, false);


--
-- Name: user_favourite_products_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.user_favourite_products_id_seq', 1, false);


--
-- Name: user_products_will_be_ordered_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.user_products_will_be_ordered_id_seq', 1, false);


--
-- Name: users_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.users_id_seq', 1, false);


--
-- Name: addresses addresses_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.addresses
    ADD CONSTRAINT addresses_pkey PRIMARY KEY (id);


--
-- Name: banks banks_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.banks
    ADD CONSTRAINT banks_pkey PRIMARY KEY (id);


--
-- Name: brands brands_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.brands
    ADD CONSTRAINT brands_pkey PRIMARY KEY (id);


--
-- Name: campaigns campaigns_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.campaigns
    ADD CONSTRAINT campaigns_pkey PRIMARY KEY (id);


--
-- Name: categories categories_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.categories
    ADD CONSTRAINT categories_pkey PRIMARY KEY (id);


--
-- Name: cities cities_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cities
    ADD CONSTRAINT cities_pkey PRIMARY KEY (id);


--
-- Name: coupons coupons_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.coupons
    ADD CONSTRAINT coupons_pkey PRIMARY KEY (id);


--
-- Name: districts districts_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.districts
    ADD CONSTRAINT districts_pkey PRIMARY KEY (id);


--
-- Name: faq_categories faq_categories_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.faq_categories
    ADD CONSTRAINT faq_categories_pkey PRIMARY KEY (id);


--
-- Name: faq_subcategories faq_subcategories_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.faq_subcategories
    ADD CONSTRAINT faq_subcategories_pkey PRIMARY KEY (id);


--
-- Name: faqs faqs_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.faqs
    ADD CONSTRAINT faqs_pkey PRIMARY KEY (id);


--
-- Name: invoices invoices_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.invoices
    ADD CONSTRAINT invoices_pkey PRIMARY KEY (id);


--
-- Name: order_products order_products_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_products
    ADD CONSTRAINT order_products_pkey PRIMARY KEY (id);


--
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (id);


--
-- Name: product_campaigns product_campaigns_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_campaigns
    ADD CONSTRAINT product_campaigns_pkey PRIMARY KEY (id);


--
-- Name: product_rates product_rates_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_rates
    ADD CONSTRAINT product_rates_pkey PRIMARY KEY (id);


--
-- Name: products products_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (id);


--
-- Name: shop_products shop_products_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shop_products
    ADD CONSTRAINT shop_products_pkey PRIMARY KEY (id);


--
-- Name: shops shops_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shops
    ADD CONSTRAINT shops_pkey PRIMARY KEY (id);


--
-- Name: slides slides_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.slides
    ADD CONSTRAINT slides_pkey PRIMARY KEY (id);


--
-- Name: subcategories subcategories_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subcategories
    ADD CONSTRAINT subcategories_pkey PRIMARY KEY (id);


--
-- Name: subsubcategories subsubcategories_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subsubcategories
    ADD CONSTRAINT subsubcategories_pkey PRIMARY KEY (id);


--
-- Name: tax_offices tax_offices_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tax_offices
    ADD CONSTRAINT tax_offices_pkey PRIMARY KEY (id);


--
-- Name: user_coupons user_coupons_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_coupons
    ADD CONSTRAINT user_coupons_pkey PRIMARY KEY (id);


--
-- Name: user_favourite_products user_favourite_products_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_favourite_products
    ADD CONSTRAINT user_favourite_products_pkey PRIMARY KEY (id);


--
-- Name: user_products_will_be_ordered user_products_will_be_ordered_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_products_will_be_ordered
    ADD CONSTRAINT user_products_will_be_ordered_pkey PRIMARY KEY (id);


--
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);


--
-- Name: addresses fk_address_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.addresses
    ADD CONSTRAINT fk_address_city FOREIGN KEY (city_id) REFERENCES public.cities(id) ON UPDATE CASCADE;


--
-- Name: faqs fk_faq_faq_subcategory; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.faqs
    ADD CONSTRAINT fk_faq_faq_subcategory FOREIGN KEY (faq_subcategory_id) REFERENCES public.faq_subcategories(id) ON UPDATE CASCADE;


--
-- Name: faq_subcategories fk_faq_subcategory_faq_category; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.faq_subcategories
    ADD CONSTRAINT fk_faq_subcategory_faq_category FOREIGN KEY (faq_category_id) REFERENCES public.faq_categories(id) ON UPDATE CASCADE;


--
-- Name: invoices fk_invoice_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.invoices
    ADD CONSTRAINT fk_invoice_city FOREIGN KEY (city_id) REFERENCES public.cities(id) ON UPDATE CASCADE;


--
-- Name: invoices fk_invoice_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.invoices
    ADD CONSTRAINT fk_invoice_user FOREIGN KEY (user_id) REFERENCES public.users(id) ON UPDATE CASCADE;


--
-- Name: tax_offices fk_office_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tax_offices
    ADD CONSTRAINT fk_office_city FOREIGN KEY (city_id) REFERENCES public.cities(id) ON UPDATE CASCADE;


--
-- Name: tax_offices fk_office_district; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tax_offices
    ADD CONSTRAINT fk_office_district FOREIGN KEY (district_id) REFERENCES public.districts(id) ON UPDATE CASCADE;


--
-- Name: orders fk_order_claim_address; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT fk_order_claim_address FOREIGN KEY (claim_address_id) REFERENCES public.addresses(id) ON UPDATE CASCADE;


--
-- Name: orders fk_order_invoice; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT fk_order_invoice FOREIGN KEY (invoice_id) REFERENCES public.invoices(id) ON UPDATE CASCADE;


--
-- Name: order_products fk_order_product_order; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_products
    ADD CONSTRAINT fk_order_product_order FOREIGN KEY (order_id) REFERENCES public.orders(id) ON UPDATE CASCADE;


--
-- Name: order_products fk_order_product_product; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_products
    ADD CONSTRAINT fk_order_product_product FOREIGN KEY (product_id) REFERENCES public.products(id) ON UPDATE CASCADE;


--
-- Name: orders fk_order_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT fk_order_user FOREIGN KEY (user_id) REFERENCES public.users(id) ON UPDATE CASCADE;


--
-- Name: products fk_product_brand; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT fk_product_brand FOREIGN KEY (brand_id) REFERENCES public.brands(id) ON UPDATE CASCADE;


--
-- Name: product_campaigns fk_product_campaign_campaign; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_campaigns
    ADD CONSTRAINT fk_product_campaign_campaign FOREIGN KEY (campaign_id) REFERENCES public.campaigns(id) ON UPDATE CASCADE;


--
-- Name: product_campaigns fk_product_campaign_product; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_campaigns
    ADD CONSTRAINT fk_product_campaign_product FOREIGN KEY (product_id) REFERENCES public.products(id) ON UPDATE CASCADE;


--
-- Name: products fk_product_subsubcategory; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT fk_product_subsubcategory FOREIGN KEY (subsubcategory_id) REFERENCES public.subsubcategories(id) ON UPDATE CASCADE;


--
-- Name: product_rates fk_rate_product; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_rates
    ADD CONSTRAINT fk_rate_product FOREIGN KEY (product_id) REFERENCES public.products(id) ON UPDATE CASCADE;


--
-- Name: product_rates fk_rate_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_rates
    ADD CONSTRAINT fk_rate_user FOREIGN KEY (user_id) REFERENCES public.users(id) ON UPDATE CASCADE;


--
-- Name: shops fk_shop_bank; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shops
    ADD CONSTRAINT fk_shop_bank FOREIGN KEY (bank_id) REFERENCES public.banks(id) ON UPDATE CASCADE;


--
-- Name: shops fk_shop_invoice_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shops
    ADD CONSTRAINT fk_shop_invoice_city FOREIGN KEY (invoice_city_id) REFERENCES public.cities(id) ON UPDATE CASCADE;


--
-- Name: shops fk_shop_invoice_district; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shops
    ADD CONSTRAINT fk_shop_invoice_district FOREIGN KEY (invoice_district_id) REFERENCES public.districts(id) ON UPDATE CASCADE;


--
-- Name: shop_products fk_shop_product_product; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shop_products
    ADD CONSTRAINT fk_shop_product_product FOREIGN KEY (product_id) REFERENCES public.products(id) ON UPDATE CASCADE;


--
-- Name: shop_products fk_shop_product_shop; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shop_products
    ADD CONSTRAINT fk_shop_product_shop FOREIGN KEY (shop_id) REFERENCES public.shops(id) ON UPDATE CASCADE;


--
-- Name: shops fk_shop_selling_subcategory; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shops
    ADD CONSTRAINT fk_shop_selling_subcategory FOREIGN KEY (selling_subcategory_id) REFERENCES public.subcategories(id) ON UPDATE CASCADE;


--
-- Name: shops fk_shop_tax_office; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shops
    ADD CONSTRAINT fk_shop_tax_office FOREIGN KEY (tax_office_id) REFERENCES public.tax_offices(id) ON UPDATE CASCADE;


--
-- Name: shops fk_shop_tax_office_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.shops
    ADD CONSTRAINT fk_shop_tax_office_city FOREIGN KEY (tax_office_city_id) REFERENCES public.cities(id) ON UPDATE CASCADE;


--
-- Name: subcategories fk_subcategory_category; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subcategories
    ADD CONSTRAINT fk_subcategory_category FOREIGN KEY (category_id) REFERENCES public.categories(id) ON UPDATE CASCADE;


--
-- Name: subsubcategories fk_subsubcategory_subcategory; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subsubcategories
    ADD CONSTRAINT fk_subsubcategory_subcategory FOREIGN KEY (subcategory_id) REFERENCES public.subcategories(id) ON UPDATE CASCADE;


--
-- Name: user_coupons fk_user_coupon_coupon; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_coupons
    ADD CONSTRAINT fk_user_coupon_coupon FOREIGN KEY (coupon_id) REFERENCES public.coupons(id) ON UPDATE CASCADE;


--
-- Name: user_coupons fk_user_coupon_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_coupons
    ADD CONSTRAINT fk_user_coupon_user FOREIGN KEY (user_id) REFERENCES public.users(id) ON UPDATE CASCADE;


--
-- Name: user_favourite_products fk_user_favourite_product_product; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_favourite_products
    ADD CONSTRAINT fk_user_favourite_product_product FOREIGN KEY (product_id) REFERENCES public.products(id) ON UPDATE CASCADE;


--
-- Name: user_favourite_products fk_user_favourite_product_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_favourite_products
    ADD CONSTRAINT fk_user_favourite_product_user FOREIGN KEY (user_id) REFERENCES public.users(id) ON UPDATE CASCADE;


--
-- Name: user_products_will_be_ordered fk_user_products_will_be_ordered_product; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_products_will_be_ordered
    ADD CONSTRAINT fk_user_products_will_be_ordered_product FOREIGN KEY (product_id) REFERENCES public.products(id) ON UPDATE CASCADE;


--
-- Name: user_products_will_be_ordered fk_user_products_will_be_ordered_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_products_will_be_ordered
    ADD CONSTRAINT fk_user_products_will_be_ordered_user FOREIGN KEY (user_id) REFERENCES public.users(id) ON UPDATE CASCADE;


--
-- PostgreSQL database dump complete
--

