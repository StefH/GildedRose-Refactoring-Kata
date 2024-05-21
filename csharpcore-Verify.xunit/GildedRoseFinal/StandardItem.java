package gildedrose.item;

import gildedrose.Item;

public class StandardItem extends Item{
	private static final int DAILY_QUALITY_DEGREDATION_BEFORE_EXPIRY = 1;
	private static final int DAILY_QUALITY_DEGREDATION_AFTER_EXPIRY = 2;

	public StandardItem(String name, int sellIn, int quality){
		super(name, sellIn, quality);
	}

	@Override
	public void updateQuality(){
		if(isExpired()){
			decreaseQuality(DAILY_QUALITY_DEGREDATION_AFTER_EXPIRY);
		}else{
			decreaseQuality(DAILY_QUALITY_DEGREDATION_BEFORE_EXPIRY);
		}
	}
}
