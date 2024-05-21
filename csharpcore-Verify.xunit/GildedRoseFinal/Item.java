package gildedrose;

public abstract class Item {
	public static final int MAX_ITEM_QUALITY = 50;
	public static final int MIN_ITEM_QUALITY = 0;

	private final String name;
	private int sellInDays;
	private int quality;

	public Item(String name, int sellIn, int quality) {
		this.name = name;
		this.sellInDays = sellIn;
		this.quality = quality;
	}
	
	public void updateSellByDate(){
		sellInDays--;
	}

	public void decreaseQuality(int amount){
		if(quality > MIN_ITEM_QUALITY){
			quality -= amount;
		}
	}
	
	public void increaseQuality(int amount){
		if(quality < MAX_ITEM_QUALITY){
			quality += amount;
		}
	}
	
	public boolean isExpired(){
		return sellInDays < 0;
	}
	
	public String getName(){
		return name;
	}
	
	public int getSellInDays(){
		return sellInDays;
	}
	
	public int getQuality(){
		return quality;
	}
	
	public void setQuality(int quality){
		this.quality = quality;
	}
	
	public abstract void updateQuality();
	
	@Override
	public String toString() {
		return this.name + ", " + this.sellInDays + ", " + this.quality;
	}
}