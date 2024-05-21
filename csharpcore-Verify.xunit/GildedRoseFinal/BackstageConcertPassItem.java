package gildedrose.item;

import gildedrose.Item;

public class BackstageConcertPassItem extends Item{
	private static final int CONCERT_CLOSE_DAYS = 10;
	private static final int CONCERT_VERY_CLOSE_DAYS = 5;
	private static final int QUALITY_INCREASE_VERY_CLOSE = 3;
	private static final int QUALITY_INCREASE_CLOSE = 2;
	private static final int QUALITY_INCREASE_NORMAL = 1;

	public BackstageConcertPassItem(int sellIn, int quality){
		super("Backstage passes to a TAFKAL80ETC concert", sellIn, quality);
	}
	
	@Override
	public void updateQuality(){
		if(isExpired()){
			setQuality(0);
		}else if(getSellInDays() < CONCERT_VERY_CLOSE_DAYS){
			increaseQuality(QUALITY_INCREASE_VERY_CLOSE);
		}else if(getSellInDays() < CONCERT_CLOSE_DAYS){
			increaseQuality(QUALITY_INCREASE_CLOSE);
		}else{
			increaseQuality(QUALITY_INCREASE_NORMAL);
		}
	}
}
