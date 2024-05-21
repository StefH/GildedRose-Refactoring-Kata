package gildedrose.item;

import gildedrose.Item;

public class SulfurasHandOfRagnarosItem extends Item{

	public SulfurasHandOfRagnarosItem(int sellIn, int quality){
		super("Sulfuras, Hand of Ragnaros", sellIn, quality);
	}
	
	@Override
	public boolean isExpired(){
		return false;
	}

	@Override
	public void updateSellByDate(){
	}
	
	@Override
	public void updateQuality(){
	}
}
