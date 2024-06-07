package gildedrose;

import java.util.List;

class GildedRose{

	List<Item> items;

	public GildedRose(List<Item> items){
		this.items = items;
	}

	public void dailyItemUpdate(){
		for(Item item : items){
			item.UpdateSellInDays();
			item.updateQuality();
		}
	}
}