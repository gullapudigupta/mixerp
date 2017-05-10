-- Column: core.items.item_sold_points

-- ALTER TABLE core.items DROP COLUMN item_sold_points;

ALTER TABLE core.items
    ADD COLUMN item_sold_points integer NOT NULL;
	
	INSERT INTO localization.resources(
	resource_id, resource_class, key, value)
	VALUES (2117, 'ScrudResource', 'item_sold_points', 'item Sold Points');
	
	INSERT INTO localization.resources(
	resource_id, resource_class, key, value)
	VALUES (2118, 'Titles', 'ItemSoldPoints', 'item Sold Points');