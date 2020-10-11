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

SELECT pg_catalog.setval('public.banks_id_seq', 1, false);


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

SELECT pg_catalog.setval('public.cities_id_seq', 1, false);


--
-- Name: coupons_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.coupons_id_seq', 1, false);


--
-- Name: districts_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.districts_id_seq', 1, false);


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

SELECT pg_catalog.setval('public.tax_offices_id_seq', 1, false);


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

