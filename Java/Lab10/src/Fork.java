class Fork {
    private boolean isTaken = false;

    public synchronized boolean pickUp() {
        if (!isTaken) {
            isTaken = true;
            return true;
        }
        return false;
    }

    public synchronized void putDown() {
        isTaken = false;
    }
}


