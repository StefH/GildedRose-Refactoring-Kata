package gildedrose.item;

import gildedrose.Item;

public class AgedBrieItem extends Item{
	private static final int QUALITY_INCREASE_BEFORE_EXPIRY = 1;
	private static final int QUALITY_INCREASE_AFTER_EXPIRY = 2;

	public AgedBrieItem(int sellIn, int quality){
		super("Aged Brie", sellIn, quality);
	}

	@Override
	public void updateQuality(){
		increaseQuality(isExpired() ? QUALITY_INCREASE_AFTER_EXPIRY : QUALITY_INCREASE_BEFORE_EXPIRY);
	}
}
